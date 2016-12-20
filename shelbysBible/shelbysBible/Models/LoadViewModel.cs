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

        public string FullPath { get; set; }
        public string FileSize { get; set; }

        public BookList bookList { get; set; }

        public bool IsIncludeText { get; set; }
        public TextViewModel Text { get; set; }

        public LoadViewModel(string book, int currentChapter)
        {
            Text = new TextViewModel();
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

            FullPath = string.Format("{0}{1}/{2}_{3}.mp3", FilePath, BookFolderName, BookFileName, Chapter);            

            bookList = new BookList()
            {
                CurrentBook = book,
                CurrentChapter = currentChapter
            };
        }
    }
}