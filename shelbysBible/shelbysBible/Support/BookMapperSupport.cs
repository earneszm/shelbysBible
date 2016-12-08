using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shelbysBible.Support
{
    public static class BookMapperSupport
    {
        public static Dictionary<string, string> Map = new Dictionary<string, string>()
        {
            {"genesis", "B1_Genesis"},
            {"exodus", "B2_Exodus"},
            {"leviticus", "B3_Leviticus"},
            {"numbers", "B4_Numbers"},
            {"deuteronomy", "B5_Deuteronomy"},
            {"joshua", "B6_Joshua"},
            {"judges", "B7_Judges"},
            {"ruth", "B8_Ruth"},
            {"1samuel", "B9_1Samuel"},
            {"2samuel", "B10_2Samuel"},
            {"1kings", "B11_1Kings"},
            {"2kings", "B12_2Kings"},
            {"1chronicles", "B13_1Chronicles"},
            {"2chronicles", "B14_2Chronicles"},
            {"ezra", "B15_Ezra"},
            {"nehemiah", "B16_Nehemiah"},
            {"esther", "B17_Esther"},
            {"job", "B18_Job"},
            {"psalms", "B19_Psalm"},
            {"proverbs", "B20_Proverbs"},
            {"ecclesiastes", "B21_Ecclesiastes"},
            {"songofsoloman", "B22_SongOfSoloman"},
            {"isaiah", "B23_Isaiah"},
            {"jeremiah", "B24_Jeremiah"},
            {"lamentations", "B25_Lamentations"},
            {"ezekiel", "B26_Ezekiel"}
        };
    }
}