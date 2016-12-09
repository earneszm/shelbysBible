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
        public string Book { get; set; }
        public int Chapter { get; set; }

        public BookList bookList { get; set; }

        public LoadViewModel(BookData bookData, int currentChapter)
        {
            BookFolderName = bookData.Location;
            Book = bookData.Name;
            Chapter = currentChapter;

            bookList = new BookList()
            {
                CurrentBook = bookData.Name,
                CurrentChapter = currentChapter
            };
        }
    }
}