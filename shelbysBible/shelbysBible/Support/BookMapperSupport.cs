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
            {"genesis",        new BookData() { Name = "Genesis"         , Location = "B1_Genesis"           , NumberOfChapters = 50 , ApiID="Gen", bookEnum = BibleBooksEnum.genesis} },
            {"exodus",         new BookData() { Name = "Exodus"          , Location = "B2_Exodus"            , NumberOfChapters = 40 , ApiID="Exod", bookEnum = BibleBooksEnum.exodus} },
            {"leviticus",      new BookData() { Name = "Leviticus"       , Location = "B3_Leviticus"         , NumberOfChapters = 27 , ApiID="Lev", bookEnum = BibleBooksEnum.leviticus} },
            {"numbers",        new BookData() { Name = "Numbers"         , Location = "B4_Numbers"           , NumberOfChapters = 36 , ApiID="Num", bookEnum = BibleBooksEnum.numbers} },
            {"deuteronomy",    new BookData() { Name = "Deuteronomy"     , Location = "B5_Deuteronomy"       , NumberOfChapters = 34 , ApiID="Deut", bookEnum = BibleBooksEnum.deuteronomy} },
            {"joshua",         new BookData() { Name = "Joshua"          , Location = "B6_Joshua"            , NumberOfChapters = 24 , ApiID="Josh", bookEnum = BibleBooksEnum.joshua} },
            {"judges",         new BookData() { Name = "Judges"          , Location = "B7_Judges"            , NumberOfChapters = 21 , ApiID="Judg", bookEnum = BibleBooksEnum.judges} },
            {"ruth",           new BookData() { Name = "Ruth"            , Location = "B8_Ruth"              , NumberOfChapters = 4  , ApiID="Ruth", bookEnum = BibleBooksEnum.ruth} },
            {"samuel1",        new BookData() { Name = "1Samuel"         , Location = "B9_1Samuel"           , NumberOfChapters = 31 , ApiID="1Sam", bookEnum = BibleBooksEnum.samuel1} },
            {"samuel2",        new BookData() { Name = "2Samuel"         , Location = "B10_2Samuel"          , NumberOfChapters = 24 , ApiID="2Sam", bookEnum = BibleBooksEnum.samuel2} },
            {"kings1",         new BookData() { Name = "1Kings"          , Location = "B11_1Kings"           , NumberOfChapters = 22 , ApiID="1Kgs", bookEnum = BibleBooksEnum.kings1} },
            {"kings2",         new BookData() { Name = "2Kings"          , Location = "B12_2Kings"           , NumberOfChapters = 25 , ApiID="2Kgs", bookEnum = BibleBooksEnum.kings2} },
            {"chronicles1",    new BookData() { Name = "1Chronicles"     , Location = "B13_1Chronicles"      , NumberOfChapters = 29 , ApiID="1Chr", bookEnum = BibleBooksEnum.chronicles1} },
            {"chronicles2",    new BookData() { Name = "2Chronicles"     , Location = "B14_2Chronicles"      , NumberOfChapters = 36 , ApiID="2Chr", bookEnum = BibleBooksEnum.chronicles2} },
            {"ezra",           new BookData() { Name = "Ezra"            , Location = "B15_Ezra"             , NumberOfChapters = 10 , ApiID="Ezra", bookEnum = BibleBooksEnum.ezra} },
            {"nehemiah",       new BookData() { Name = "Nehemiah"        , Location = "B16_Nehemiah"         , NumberOfChapters = 13 , ApiID="Neh", bookEnum = BibleBooksEnum.nehemiah} },
            {"esther",         new BookData() { Name = "Esther"          , Location = "B17_Esther"           , NumberOfChapters = 10 , ApiID="Esth", bookEnum = BibleBooksEnum.esther} },
            {"job",            new BookData() { Name = "Job"             , Location = "B18_Job"              , NumberOfChapters = 42 , ApiID="Job", bookEnum = BibleBooksEnum.job} },
            {"psalms",         new BookData() { Name = "Psalms"          , Location = "B19_Psalm"            , NumberOfChapters = 150, ApiID="Ps", bookEnum = BibleBooksEnum.psalms} },
            {"proverbs",       new BookData() { Name = "Proverbs"        , Location = "B20_Proverbs"         , NumberOfChapters = 31 , ApiID="Prov", bookEnum = BibleBooksEnum.proverbs} },
            {"ecclesiastes",   new BookData() { Name = "Ecclesiastes"    , Location = "B21_Ecclesiastes"     , NumberOfChapters = 12 , ApiID="Eccl", bookEnum = BibleBooksEnum.ecclesiastes} },
            {"songofsoloman",  new BookData() { Name = "Song of Solomon" , Location = "B22_SongOfSoloman"    , NumberOfChapters = 8  , ApiID="Song", bookEnum = BibleBooksEnum.songofsoloman} },
            {"isaiah",         new BookData() { Name = "Isaiah"          , Location = "B23_Isaiah"           , NumberOfChapters = 66 , ApiID="Isa", bookEnum = BibleBooksEnum.isaiah} },
            {"jeremiah",       new BookData() { Name = "Jeremiah"        , Location = "B24_Jeremiah"         , NumberOfChapters = 52 , ApiID="Jer", bookEnum = BibleBooksEnum.jeremiah} },
            {"lamentations",   new BookData() { Name = "Lamentations"    , Location = "B25_Lamentations"     , NumberOfChapters = 5  , ApiID="Lam", bookEnum = BibleBooksEnum.lamentations} },
            {"ezekiel",        new BookData() { Name = "Ezekiel"         , Location = "B26_Ezekiel"          , NumberOfChapters = 48 , ApiID="Ezek", bookEnum = BibleBooksEnum.ezekiel} },
            {"daniel",         new BookData() { Name = "Daniel"          , Location = "B27_Daniel"           , NumberOfChapters = 12 , ApiID="Dan", bookEnum = BibleBooksEnum.daniel} },
            {"hosea",          new BookData() { Name = "Hosea"           , Location = "B28_Hosea"            , NumberOfChapters = 14 , ApiID="Hos", bookEnum = BibleBooksEnum.hosea} },
            {"joel",           new BookData() { Name = "Joel"            , Location = "B29_Joel"             , NumberOfChapters = 3  , ApiID="Joel", bookEnum = BibleBooksEnum.joel} },
            {"amos",           new BookData() { Name = "Amos"            , Location = "B30_Amos"             , NumberOfChapters = 9  , ApiID="Amos", bookEnum = BibleBooksEnum.amos} },
            {"obadiah",        new BookData() { Name = "Obadiah"         , Location = "B31_Obadiah"          , NumberOfChapters = 1  , ApiID="Obad", bookEnum = BibleBooksEnum.obadiah} },
            {"jonah",          new BookData() { Name = "Jonah"           , Location = "B32_Jonah"            , NumberOfChapters = 4  , ApiID="Jonah", bookEnum = BibleBooksEnum.jonah} },
            {"micah",          new BookData() { Name = "Micah"           , Location = "B33_Micah"            , NumberOfChapters = 7  , ApiID="Mic", bookEnum = BibleBooksEnum.micah} },
            {"nahum",          new BookData() { Name = "Nahum"           , Location = "B34_Nahum"            , NumberOfChapters = 3  , ApiID="Nah", bookEnum = BibleBooksEnum.nahum} },
            {"habakkuk",       new BookData() { Name = "Habakkuk"        , Location = "B35_Habakkuk"         , NumberOfChapters = 3  , ApiID="Hab", bookEnum = BibleBooksEnum.habakkuk} },
            {"zephaniah",      new BookData() { Name = "Zephaniah"       , Location = "B36_Zephaniah"        , NumberOfChapters = 3  , ApiID="Zeph", bookEnum = BibleBooksEnum.zephaniah} },
            {"haggai",         new BookData() { Name = "Haggai"          , Location = "B37_Haggai"           , NumberOfChapters = 2  , ApiID="Hag", bookEnum = BibleBooksEnum.haggai} },
            {"zechariah",      new BookData() { Name = "Zechariah"       , Location = "B38_Zechariah"        , NumberOfChapters = 14 , ApiID="Zech", bookEnum = BibleBooksEnum.zechariah} },
            {"malachi",        new BookData() { Name = "Malachi"         , Location = "B39_Malachi"          , NumberOfChapters = 4  , ApiID="Mal", bookEnum = BibleBooksEnum.malachi} },
            //New Testament                                                                                                          
            {"matthew",        new BookData() { Name = "Matthew"         , Location = "B1_Matthew"           , NumberOfChapters = 28 , ApiID="Matt", bookEnum = BibleBooksEnum.matthew} },
            {"mark",           new BookData() { Name = "Mark"            , Location = "B2_Mark"              , NumberOfChapters = 16 , ApiID="Mark", bookEnum = BibleBooksEnum.mark} },
            {"luke",           new BookData() { Name = "Luke"            , Location = "B3_Luke"              , NumberOfChapters = 24 , ApiID="Luke", bookEnum = BibleBooksEnum.luke} },
            {"john",           new BookData() { Name = "John"            , Location = "B4_John"              , NumberOfChapters = 21 , ApiID="John", bookEnum = BibleBooksEnum.john} },
            {"acts",           new BookData() { Name = "Acts"            , Location = "B5_Acts"              , NumberOfChapters = 28 , ApiID="Acts", bookEnum = BibleBooksEnum.acts} },
            {"romans",         new BookData() { Name = "Romans"          , Location = "B6_Romans"            , NumberOfChapters = 16 , ApiID="Rom", bookEnum = BibleBooksEnum.romans} },
            {"corinthians1",   new BookData() { Name = "1 Corinthians"   , Location = "B7_1Corinthians"      , NumberOfChapters = 16 , ApiID="1Cor", bookEnum = BibleBooksEnum.corinthians1} },
            {"corinthians2",   new BookData() { Name = "2 Corinthians"   , Location = "B8_2Corinthians"      , NumberOfChapters = 13 , ApiID="2Cor", bookEnum = BibleBooksEnum.corinthians2} },
            {"galatians",      new BookData() { Name = "Galatians"       , Location = "B9_Galatians"         , NumberOfChapters = 6  , ApiID="Gal", bookEnum = BibleBooksEnum.galatians} },
            {"ephesians",      new BookData() { Name = "Ephesians"       , Location = "B10_Ephesians"        , NumberOfChapters = 6  , ApiID="Eph", bookEnum = BibleBooksEnum.ephesians} },
            {"philippians",    new BookData() { Name = "Philippians"     , Location = "B11_Philippians"      , NumberOfChapters = 4  , ApiID="Phil", bookEnum = BibleBooksEnum.philippians} },
            {"colossians",     new BookData() { Name = "Colossians"      , Location = "B12_Colossians"       , NumberOfChapters = 4  , ApiID="Col", bookEnum = BibleBooksEnum.colossians} },
            {"thessalonians1", new BookData() { Name = "1 Thessalonians" , Location = "B13_1Thessalonians"   , NumberOfChapters = 5  , ApiID="1Thess", bookEnum = BibleBooksEnum.thessalonians1} },
            {"thessalonians2", new BookData() { Name = "2 Thessalonians" , Location = "B14_2Thessalonians"   , NumberOfChapters = 3  , ApiID="2Thess", bookEnum = BibleBooksEnum.thessalonians2} },
            {"timothy1",       new BookData() { Name = "1 Timothy"       , Location = "B15_1Timothy"         , NumberOfChapters = 6  , ApiID="1Tim", bookEnum = BibleBooksEnum.timothy1} },
            {"timothy2",       new BookData() { Name = "2 Timothy"       , Location = "B16_2Timothy"         , NumberOfChapters = 4  , ApiID="2Tim", bookEnum = BibleBooksEnum.timothy2} },
            {"titus",          new BookData() { Name = "Titus"           , Location = "B17_Titus"            , NumberOfChapters = 3  , ApiID="Titus", bookEnum = BibleBooksEnum.titus} },
            {"philemon",       new BookData() { Name = "Philemon"        , Location = "B18_Philomen"         , NumberOfChapters = 1  , ApiID="Phlm", bookEnum = BibleBooksEnum.philemon} },
            {"hebrews",        new BookData() { Name = "Hebrews"         , Location = "B19_Hebrews"          , NumberOfChapters = 13 , ApiID="Heb", bookEnum = BibleBooksEnum.hebrews} },
            {"james",          new BookData() { Name = "James"           , Location = "B20_James"            , NumberOfChapters = 5  , ApiID="Jas", bookEnum = BibleBooksEnum.james} },
            {"peter1",         new BookData() { Name = "1 Peter"         , Location = "B21_1Peter"           , NumberOfChapters = 5  , ApiID="1Pet", bookEnum = BibleBooksEnum.peter1} },
            {"peter2",         new BookData() { Name = "2 Peter"         , Location = "B22_2Peter"           , NumberOfChapters = 3  , ApiID="2Pet", bookEnum = BibleBooksEnum.peter2} },
            {"john1",          new BookData() { Name = "1 John"          , Location = "B23_1John"            , NumberOfChapters = 5  , ApiID="1John", bookEnum = BibleBooksEnum.john1} },
            {"john2",          new BookData() { Name = "2 John"          , Location = "B24_2John"            , NumberOfChapters = 1  , ApiID="2John", bookEnum = BibleBooksEnum.john2} },
            {"john3",          new BookData() { Name = "3 John"          , Location = "B25_3John"            , NumberOfChapters = 1  , ApiID="3John", bookEnum = BibleBooksEnum.john3} },
            {"jude",           new BookData() { Name = "Jude"            , Location = "B26_Jude"             , NumberOfChapters = 1  , ApiID="Jude", bookEnum = BibleBooksEnum.jude} },
            {"revelation",     new BookData() { Name = "Revelation"      , Location = "B27_Revelation"       , NumberOfChapters = 22 , ApiID="Rev", bookEnum = BibleBooksEnum.revelation} }
        };
    }
}