using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shelbysBible.Support;

namespace shelbysBible.Models
{
    public class BookList
    {
        public bool IsHomePage { get; set; }
        public string CurrentBook { get; set; }
        public int CurrentChapter { get; set; }
        
        public bool ShowNavigateLeft()
        {
            if (IsHomePage)
                return false;

            if (CurrentBook != BookMapperSupport.BookData.OrderBy(x => x.Value.Order).First().Key)
                return true;

            if (CurrentChapter > 1)
                return true;

            return false;
        }

        public bool ShowNavigateRight()
        {
            if (IsHomePage)
                return false;

            if (CurrentBook != BookMapperSupport.BookData.OrderByDescending(x => x.Value.Order).First().Key)
                return true;

            if (CurrentChapter < BookMapperSupport.BookData[CurrentBook].NumberOfChapters)
                return true;

            return false;
        }
    }
}