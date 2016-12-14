using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shelbysBible.Models;
using shelbysBible.Support;
using Newtonsoft.Json;
using System.Configuration;

namespace shelbysBible.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new HomeViewModel();
            viewModel.bookList.IsHomePage = true;
            return View(viewModel);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult LoadRedirect(string book = "")
        {
            return Redirect("/load/Genesis/1");
        }

        public ActionResult Load(string book = "Genesis", int chapter = 1)
        {
            
            var viewModel = new LoadViewModel(book, chapter);

            try
            {
                var apiResponse = RestSupport.RequestBook(BookMapperSupport.BookData[book.ToLower()].ApiID, chapter);
                var deserialize = JsonConvert.DeserializeObject<RootObject>(apiResponse);
                viewModel.EsvHTML = deserialize.response.chapters.FirstOrDefault().text;
                viewModel.Copyright = deserialize.response.chapters.FirstOrDefault().copyright;
                viewModel.FUMsData = deserialize.response.meta.fums;
            }
            catch
            {
                viewModel.EsvHTML = "<h3>Unable to load text.</h3>";
            }

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
            return Redirect(string.Format("/load/{0}/{1}", targetBook.Name, 1));
        }
    }
}