using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shelbysBible.Models
{
    public class HomeViewModel
    {
        public BookList bookList { get; set; }

        public HomeViewModel()
        {
            bookList = new BookList() { CurrentBook = "", CurrentChapter = 0 };
        }
    }
}