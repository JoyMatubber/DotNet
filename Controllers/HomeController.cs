using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV_20_41959_1_.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult About()
        {
            ViewBag.Name="Joy Matubber";
            ViewBag.Id = "20-41959-1";


            ViewData["Dep"] = "CSE";
            ViewData["Sem"] = "9th ( Running ) ";
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }


        public ActionResult Project()
        {
            return View();
        }

        //Reference
        public ActionResult Reference()
        {
            ViewBag.RefName ="TANVIR AHMED";
            ViewBag.RefEmail= "tanvir.ahmed@aiub.edu";
           
            ViewData["Pos"] = "Faculty";
            return View();
        }

    }
}