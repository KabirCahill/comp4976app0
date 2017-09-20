using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HappyMVC.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles(Server.MapPath("~/TextFiles"));

            ViewBag.Files = files;

            return View();
        }

        public new ActionResult Content(string fileName)
        {
            ViewBag.Content = System.IO.File.ReadAllText(Server.MapPath("~/TextFiles/" + fileName + ".txt"));

            return View();
        }
    }
}