using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shelbysBible.Support
{
    public static class StringUtils
    {
        public static string GetFriendlyName(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;

            return input;
        }
    }
}