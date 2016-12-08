using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shelbysBible.Models;

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
            return RedirectPermanent("/Load/Ezekiel/1");
        }

        public ActionResult Load(string book = "", int chapter = 0)
        {

            var viewModel = new LoadViewModel();
            viewModel.Book = book;
            viewModel.Chapter = chapter;
            return View(viewModel);
        }
    }
}