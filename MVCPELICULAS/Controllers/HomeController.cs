﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPELICULAS.Controllers
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

        
        public ActionResult _Login(String usuario,String pass)
        {
            Session["TOVALIDAR"] = true;
            if(usuario=="admin"&& pass == "admin")
            {
                Session["VALIDADO"] = true;
            }
            return View();
        }
    }
}