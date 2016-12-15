using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shelbysBible.Models;
using shelbysBible.Support;
using Newtonsoft.Json;
using System.Configuration;
using System.IO;

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

        public JsonResult LoadPartial(string book = "Genesis", int chapter = 1)
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

            var output = RenderPartialViewToString("_Load", viewModel);

            return Json( new { html = output, book = book, chapter = chapter }, JsonRequestBehavior.AllowGet);

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

        public JsonResult NavigateLeft(string book, int chapter)
        {
            if(chapter > 1)
                return LoadPartial(book, chapter - 1);

            var bookNum = (int)BookMapperSupport.BookData[book.ToLower()].bookEnum;
            var nextBook = bookNum > 1 ? bookNum - 1 : bookNum;

            var targetBook = BookMapperSupport.BookData[((BibleBooksEnum)nextBook).ToString()];

            // return Redirect(string.Format("/load/{0}/{1}", targetBook.Name, targetBook.NumberOfChapters));

            return LoadPartial(targetBook.Name, targetBook.NumberOfChapters);
        }

        public JsonResult NavigateRight(string book, int chapter)
        {        
            var currentBook = BookMapperSupport.BookData[book.ToLower()];
            if (chapter < currentBook.NumberOfChapters)
                return LoadPartial(book, chapter + 1);

            var nextBook = (int)currentBook.bookEnum >= Enum.GetNames(typeof(BibleBooksEnum)).Length ? 1 : (int)currentBook.bookEnum + 1;

            var targetBook = BookMapperSupport.BookData[((BibleBooksEnum)nextBook).ToString()];
            return LoadPartial(targetBook.Name, 1);
        }

        public string RenderPartialViewToString(string name, object model)
        {
            if (string.IsNullOrEmpty(name))
                name = ControllerContext.RouteData.GetRequiredString("action");

            ViewData.Model = model;

            using (var writer = new StringWriter())
            {
                ViewEngineResult viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, name);
                ViewContext viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, writer);

                // copy model state items to the html helper 
                foreach (var item in viewContext.Controller.ViewData.ModelState)
                    if (!viewContext.ViewData.ModelState.Keys.Contains(item.Key))
                        viewContext.ViewData.ModelState.Add(item);


                viewResult.View.Render(viewContext, writer);

                return writer.GetStringBuilder().ToString();
            }
        }
    }
}