using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shelbysBible.Models;
using shelbysBible.Support;

namespace shelbysBible.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("/load/Genesis/1");
        }

        public ActionResult LoadRedirect(string book = "")
        {
            return Redirect("/load/Genesis/1");
        }

        public ActionResult Load(string book, int chapter)
        {
            var viewModel = new LoadViewModel(BookMapperSupport.BookData[book.ToLower()], chapter);

            //viewModel.BookFolderName = BookMapperSupport.Map[book.ToLower()];
            //viewModel.Book = book;
            //viewModel.Chapter = chapter;
            return View(viewModel);
        }

        public ActionResult NavigateLeft(string book, int chapter)
        {
            if(chapter > 1)
                return Redirect(string.Format("/load/{0}/{1}", book, chapter - 1));

            var bookNum = (int)BookMapperSupport.BookData[book.ToLower()].bookEnum;
            var nextBook = bookNum > 1 ? bookNum - 1 : bookNum;

            var targetBook = BookMapperSupport.BookData[((BibleBooksEnum)nextBook).ToString()];

            return Redirect(string.Format("/load/{0}/{1}", targetBook.Name, targetBook.NumberOfChapters));
        }

        public ActionResult NavigateRight(string book, int chapter)
        {        
            var currentBook = BookMapperSupport.BookData[book.ToLower()];
            if(chapter < currentBook.NumberOfChapters)
                return Redirect(string.Format("/load/{0}/{1}", book, chapter + 1));

            var nextBook = (int)currentBook.bookEnum >= Enum.GetNames(typeof(BibleBooksEnum)).Length ? 1 : (int)currentBook.bookEnum + 1;

            var targetBook = BookMapperSupport.BookData[((BibleBooksEnum)nextBook).ToString()];
            return Redirect(string.Format("/load/{0}/{1}", targetBook.Name, targetBook.NumberOfChapters));
        }
    }
}