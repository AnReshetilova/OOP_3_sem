using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab9
{
    class StringEditor
    {
        public static string DeleteSpaces(string str)
        {
            return str.Replace("  ", " ");
        }
        public static string DeleteSigns(string str)
        {
            return Regex.Replace(str, "[,!?]", "");
        }
        public static string FirstLetterToUpper(string str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();
        }
        public static string AddSmile(string str)
        {
            return str + "(:";
        }
    }
}
