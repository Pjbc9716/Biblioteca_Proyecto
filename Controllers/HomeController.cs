using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intento1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult admin()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult advantagesettings()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult book()
        {
            ViewBag.Message = "book";

            return View();
        }

        public ActionResult catalog()
        {
            ViewBag.Message = "catalog";

            return View();
        }

        public ActionResult category()
        {
            ViewBag.Message = "category";

            return View();
        }

        public ActionResult home()
        {
            ViewBag.Message = "home";

            return View();
        }

        public ActionResult institution()
        {
            ViewBag.Message = "institution";

            return View();
        }

        public ActionResult listadmin()
        {
            ViewBag.Message = "listadmin";

            return View();
        }

        public ActionResult listaprovider()
        {
            ViewBag.Message = "listaprovider";

            return View();
        }

        public ActionResult listcategory()
        {
            ViewBag.Message = "listcategory";

            return View();
        }

        public ActionResult listpersonal()
        {
            ViewBag.Message = "listpersonal";

            return View();
        }

        public ActionResult listsection()
        {
            ViewBag.Message = "listsection";

            return View();
        }

        public ActionResult liststudent()
        {
            ViewBag.Message = "liststudent";

            return View();
        }

        public ActionResult listteacher()
        {
            ViewBag.Message = "listteacher";

            return View();
        }

        public ActionResult loan()
        {
            ViewBag.Message = "loan";

            return View();
        }

        public ActionResult loanpending()
        {
            ViewBag.Message = "loanpending";

            return View();
        }

        public ActionResult loanreservation()
        {
            ViewBag.Message = "loanreservation";

            return View();
        }

        public ActionResult personal()
        {
            ViewBag.Message = "personal";

            return View();
        }

        public ActionResult provider()
        {
            ViewBag.Message = "provider";

            return View();
        }

        public ActionResult report()
        {
            ViewBag.Message = "report";

            return View();
        }

        public ActionResult searchbook()
        {
            ViewBag.Message = "searchbook";

            return View();
        }

        public ActionResult section()
        {
            ViewBag.Message = "section";

            return View();
        }

        public ActionResult student()
        {
            ViewBag.Message = "student";

            return View();
        }

        public ActionResult teacher()
        {
            ViewBag.Message = "teacher";

            return View();
        }

    }
}