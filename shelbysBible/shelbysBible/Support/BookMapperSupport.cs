using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using shelbysBible.Models;

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

        public static Dictionary<string, BookData> BookData = new Dictionary<string, BookData>()
        {
            {"genesis", new BookData() { Name = "Genesis", Location = "B1_Genesis", NumberOfChapters = 50, bookEnum = BibleBooksEnum.genesis} },
            {"exodus", new BookData() { Name = "Exodus", Location = "B2_Exodus", NumberOfChapters = 40, bookEnum = BibleBooksEnum.exodus} },
            {"leviticus", new BookData() { Name = "Leviticus", Location = "B3_Leviticus", NumberOfChapters = 27, bookEnum = BibleBooksEnum.leviticus} },
            {"numbers", new BookData() { Name = "Numbers", Location = "B4_Numbers", NumberOfChapters = 36, bookEnum = BibleBooksEnum.numbers} },
            {"deuteronomy", new BookData() { Name = "Deuteronomy", Location = "B5_Deuteronomy", NumberOfChapters = 34, bookEnum = BibleBooksEnum.deuteronomy} },
            {"joshua", new BookData() { Name = "Joshua", Location = "B6_Joshua", NumberOfChapters = 24, bookEnum = BibleBooksEnum.joshua} },
            {"judges", new BookData() { Name = "Judges", Location = "B7_Judges", NumberOfChapters = 21, bookEnum = BibleBooksEnum.judges} },
            {"ruth", new BookData() { Name = "Ruth", Location = "B8_Ruth", NumberOfChapters = 4, bookEnum = BibleBooksEnum.ruth} },
            {"samuel1", new BookData() { Name = "1Samuel", Location = "B9_1Samuel", NumberOfChapters = 31, bookEnum = BibleBooksEnum.samuel1} },
            {"samuel2", new BookData() { Name = "2Samuel", Location = "B10_2Samuel", NumberOfChapters = 24, bookEnum = BibleBooksEnum.samuel2} }
        };
    }    
}