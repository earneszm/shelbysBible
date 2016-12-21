using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace shelbysBible.Support
{
    public static class ConfigUtils
    {
        // Location
        public static string LocationRoot { get; set; }
        public static string OldTestamentFolder { get; set; }
        public static string NewTestamentFolder { get; set; }

        // API
        public static string API_Url { get; set; }
        public static string API_Key { get; set; }
        public static string Verse_Of_The_Day_Url { get; set; }


        static ConfigUtils()
        {
            LocationRoot = ConfigurationManager.AppSettings["Location.Root"];
            OldTestamentFolder = ConfigurationManager.AppSettings["Location.OldTestamentFolder"];
            NewTestamentFolder = ConfigurationManager.AppSettings["Location.NewTestamentFolder"];

            API_Url = ConfigurationManager.AppSettings["API.Url"];
            API_Key = ConfigurationManager.AppSettings["API.Base64Key"];
            Verse_Of_The_Day_Url = ConfigurationManager.AppSettings["VerseOfTheDay.Url"];

        }
    }
}