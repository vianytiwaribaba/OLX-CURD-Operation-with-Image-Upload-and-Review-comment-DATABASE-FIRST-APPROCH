using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealDashDouble.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DealDoubleDBContext context = new DealDoubleDBContext();

            var allauction = context.tbl_Auction.ToList();

            return View(allauction);
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
    }
}