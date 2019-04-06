using System;
using System.Text.RegularExpressions;

namespace TestTask.Helper
{
    class StringHelper
    {
        public static String ConvertString(String s)
        {
            Regex r = new Regex("[^a-zA-Z0-9]");
            return r.Replace(s, "").ToLower();
        }
    }
}
