using System;
using System.Globalization;

namespace StringComparison
{
    public static class StringComparerExtension
    {

        public static bool Contains(this string str, string value, CompareOptions options)
        {
            return CultureInfo.InvariantCulture.CompareInfo.IndexOf(str, value, options) != -1;
        }
    }
}
