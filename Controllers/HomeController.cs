using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestShitAgain
{
    public class HomeController : Controller
    {

        kenguEntities dataBase = new kenguEntities();

        public ActionResult Index()
        {

            IEnumerable<goods> good = dataBase.goods;

            ViewBag.Goods = good;

            return View();
        }

    }
}