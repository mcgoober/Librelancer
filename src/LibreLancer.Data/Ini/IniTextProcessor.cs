using System.Linq;
using System.IO;

namespace LibreLancer.Data.Ini
{
    internal class IniTextProcessor : IIniObserver
    {       
       private readonly StringWriter stringWriter;
       private int numSections = 0;
       private int numValues = 0;

       public IniTextProcessor(StringWriter stringWriter)
       {
           this.stringWriter = stringWriter;
       }

       private void RenderSpecial(string str, string special)
       {
           if (str.Any(c => special.Contains(c)))
           {
               // String containing special chars must be rendered quoted and have any quotes double quoted
               RenderQuoted(str);
           }
           else
           {
               stringWriter.Write(str);
           }
       }

       private void RenderString(string str)
       {
           if (float.TryParse(str, out _))
           {
               RenderQuoted(str);
           }
           else if (int.TryParse(str, out _))
           {
               RenderQuoted(str);
           }
           else
           {
               RenderSpecial(str, "\", \f\n\r\t\v");
           }
       }

       private void RenderQuoted(string str)
       {
           stringWriter.Write('"');
           foreach (var c in str)
           {
               if (c == '"') stringWriter.Write('"');
               stringWriter.Write(c);
           }
           stringWriter.Write('"');
       }

       public void StartSection(string sectionName)
       {
           if (numSections > 0) stringWriter.WriteLine();
           numSections++;

           stringWriter.Write('[');
           RenderSpecial(sectionName, "\"[] \f\n\r\t\v");
           stringWriter.Write(']');
           stringWriter.WriteLine();
       }

       public void EndSection()
       {

       }

       public void StartEntry(string entryName)
       {
           RenderSpecial(entryName, "\"=[] \f\n\r\t\v");
           stringWriter.Write(" =");

           numValues = 0;
       }

       public void EndEntry()
       {
           stringWriter.WriteLine();
       }

       public void Value(object value)
       {
           stringWriter.Write(numValues > 0 ? ", " : " ");
           numValues++;

           if (value is string)
               RenderString(value.ToString());
           else
               stringWriter.Write(value);
       }

       public void Comment(string comment)
       {
           stringWriter.Write("; ");
           stringWriter.WriteLine(comment);
       }       
    }
}
