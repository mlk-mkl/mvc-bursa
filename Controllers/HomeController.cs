using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TASK4.Models;

namespace TASK4.Controllers
{
    public class HomeController : Controller
    {
        MagazineContext db = new MagazineContext();
        public ActionResult Index()
        {
            var magazines = db.Magazines;
            ViewBag.Magazines = magazines;
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.MagazineId = id;
           
            return View();
        }
        public ActionResult Buy1()
        {
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            // добавляем информацию о покупке в базу данных
            db.Purchases.Add(purchase);
            // сохраняем в бд все изменения
            db.SaveChanges();
            Buy1();
            return purchase.Person + ", thanks for purchase!";
           

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