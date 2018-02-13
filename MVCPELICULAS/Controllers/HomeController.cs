using System;
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
            ViewBag.fallopw = "";
            ViewBag.fallopwred = "";
            Session["TOVALIDAR"] = true;
            if(usuario=="admin"&& pass == "admin")
            {
                Session["VALIDADO"] = true;
            }            
            else
            {
                Session["VALIDADO"] = null;
                if ((usuario == null && pass == null))
                {
                    
                }
                if ( usuario == "" && pass == "")
                {
                    ViewBag.fallopw = "Introduzca usuario y pw";
                }
                if ((usuario != "admin" || pass != "admin")&&(usuario != "" && pass != "")
                    && (usuario != null && pass != null))
                {
                    ViewBag.fallopwred = "Usuario o pw incorrectos";
                }

            }

            return View();
        }
    }
}