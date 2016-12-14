using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using shelbysBible.Support;

namespace shelbysBible.Models
{
    public class BookData
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public string Location { get; set; }
        public int NumberOfChapters { get; set; }
        public string ApiID { get; set; }
        public BibleBooksEnum bookEnum { get; set; }
    }
}