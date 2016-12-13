using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shelbysBible.Models
{
    public class Book
    {
        public string path { get; set; }
        public string name { get; set; }
        public string id { get; set; }
    }

    public class Parent
    {
        public Book book { get; set; }
    }

    public class Chapter2
    {
        public string path { get; set; }
        public string name { get; set; }
        public string id { get; set; }
    }

    public class Next
    {
        public Chapter2 chapter { get; set; }
    }

    public class Chapter3
    {
        public string path { get; set; }
        public string name { get; set; }
        public string id { get; set; }
    }

    public class Previous
    {
        public Chapter3 chapter { get; set; }
    }

    public class Chapter
    {
        public string auditid { get; set; }
        public string label { get; set; }
        public string text { get; set; }
        public string chapter { get; set; }
        public string id { get; set; }
        public string osis_end { get; set; }
        public Parent parent { get; set; }
        public Next next { get; set; }
        public Previous previous { get; set; }
        public string copyright { get; set; }
    }

    public class Meta
    {
        public string fums { get; set; }
        public string fums_tid { get; set; }
        public string fums_js_include { get; set; }
        public string fums_js { get; set; }
        public string fums_noscript { get; set; }
    }

    public class Response
    {
        public List<Chapter> chapters { get; set; }
        public Meta meta { get; set; }
    }

    public class RootObject
    {
        public Response response { get; set; }
    }
}