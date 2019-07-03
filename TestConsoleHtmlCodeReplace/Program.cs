using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleHtmlCodeReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            String stringWithSingleQuotes = "src='http://...';";
            String withDoubleQuotes = stringWithSingleQuotes.Replace("'", "\"");
            string s=  HTMLCodeReplacer.ReplaceString.PutString("Global Industrial&#8482; Electric Auto Floor Scrubber 20&quot; Cleaning Path - Corded");
        }
    }
}
