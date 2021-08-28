using System.IO;
using System.Text;
using static BuildLL.Runtime;

namespace BuildLL
{
    public class Dotnet
    {
        public static int CPUCount = 0;
        
        static string P(string path)
        {
            return Quote(Path.GetFullPath(path));
        }
        static string M()
        {
            return CPUCount > 0 ? $"-maxcpucount:{CPUCount}" : "";
        }
        public static void Restore(string project)
        {
            RunCommand("dotnet", $"restore {M()} /nr:false {P(project)}");
        }
        public static void Build(string project)
        {
            RunCommand("dotnet", $"build {M()} /nr:false {P(project)}");
        }
        public static void Clean(string project)
        {
            RunCommand("dotnet", $"clean {M()} /nr:false {P(project)}");
        }
        public static void Run(string project, string args = null)
        {
            string a = "";
            if (!string.IsNullOrWhiteSpace(args)) a = $" -- {args}";
            RunCommand("dotnet", $"run --project {P(project)}{a}");
        }

        public static void Publish(string project, DotnetPublishSettings settings = null)
        {
            var argbuilder = new StringBuilder();
            argbuilder.Append($"publish {M()} /nr:false");
            if (!string.IsNullOrWhiteSpace(settings?.Configuration))
                argbuilder.Append(" -c ").Append(settings.Configuration);
            if (!string.IsNullOrWhiteSpace(settings?.OutputDirectory))
                argbuilder.Append(" -o ").Append(P(settings.OutputDirectory));
            if (!string.IsNullOrWhiteSpace(settings?.Runtime))
                argbuilder.Append(" -r ").Append(settings.Runtime);
            if (settings != null && settings.SelfContained)
                argbuilder.Append(" --self-contained true");
            argbuilder.Append(" ").Append(P(project));
            RunCommand("dotnet", argbuilder.ToString());
        }
    }

    public class DotnetPublishSettings
    {
        public string Configuration;
        public string OutputDirectory;
        public string Runtime;
        public bool SelfContained;
    }
}
