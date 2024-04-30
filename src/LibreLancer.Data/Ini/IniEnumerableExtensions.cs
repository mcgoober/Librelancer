using LibreLancer.Data.Ini;
using System.Collections.Generic;
using System.IO;

namespace LibreLancer.Ini
{
    public static class IniEnumerableExtensions
    {
        public static string IniToText(this IEnumerable<Section> sections)
        {
            var stringWriter = new StringWriter();
            var iniTextProcessor = new IniTextProcessor(stringWriter);
            Process(iniTextProcessor, sections);
            return stringWriter.ToString();
        }

        public static Stream IniToBinary(this IEnumerable<Section> sections)
        {
            var stream = new MemoryStream();
            //var iniBinaryProcessor = new IniBinaryProcessor(stream);
            //Process(iniBinaryProcessor, sections);
            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }

        private static void Process(IIniObserver observer, IEnumerable<Section> sections)
        {
            foreach (var section in sections)
            {
                observer.StartSection(section.Name);
                foreach (var entry in section)
                {
                    observer.StartEntry(entry.Name);
                    foreach (var value in entry)
                    {
                        observer.Value(value);
                    }
                    observer.EndEntry();
                }
                observer.EndSection();
            }
        }
    }
}
