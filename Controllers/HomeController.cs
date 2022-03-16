using Projectmvc.Models;
using Projectmvc.mymodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projectmvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            chut1Entities obj = new chut1Entities();
            var res  = obj.My_data;

         

            return View(res);
        }
       

        public ActionResult About()
        {
            ViewBag.Message = "viewbag.";
            ViewData["msg"] = "ViewData";
            TempData["msg1"] = "TempData";
            Session["msg2"] = "Session";

            return View();
        }
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            chut1Entities obj = new chut1Entities();
            var res = obj.My_data;

            return View();
        }
        [HttpPost]
        public ActionResult Create( My_data data)
        {
            chut1Entities entities = new chut1Entities();
            My_data table = new My_data();
            table.id = data.id;
            table.name = data.name;
            table.Email = data.Email;
            table.salary = data.salary;
            entities.My_data.Add(data);
            entities.SaveChanges();


            return View();
        }
    }
}