using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using shelbysBible.Support;


namespace shelbysBible.Models
{
    public class LoadViewModel
    {
        public string BookFolderName { get; set; }
        public string BookFileName { get; set; }
        public string FilePath { get; set; }
        public string Book { get; set; }
        public int Chapter { get; set; }
        public bool IsNewTestament { get; set; }

        public BookList bookList { get; set; }

        public string EsvHTML { get; set; }
        public string FUMsData { get; set; }
        public string Copyright { get; set; }

        public LoadViewModel(string book, int currentChapter)
        {
            var bookData = BookMapperSupport.BookData[book.ToLower()];
            FilePath = ConfigUtils.LocationRoot;

            if ((int)bookData.bookEnum > 39)               
                FilePath += ConfigUtils.NewTestamentFolder;
            else
                FilePath += ConfigUtils.OldTestamentFolder;

            BookFolderName = bookData.Location;
            BookFileName = bookData.Name.Replace(" ", "");
            Book = bookData.Name;
            Chapter = currentChapter;

            bookList = new BookList()
            {
                CurrentBook = book,
                CurrentChapter = currentChapter
            };
        }
    }
}