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
            return View();
        }

        public ActionResult LoadRedirect(string book = "")
        {
            return Redirect("/load/Genesis/1");
        }

        public ActionResult Load(string book = "", int chapter = 0)
        {
            var viewModel = new LoadViewModel();

            viewModel.BookFolderName = BookMapperSupport.Map[book.ToLower()];
            viewModel.Book = book;
            viewModel.Chapter = chapter;
            return View(viewModel);
        }
    }
}