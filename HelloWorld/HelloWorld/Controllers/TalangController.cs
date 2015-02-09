using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class TalangController : Controller
    {
        //
        // GET: /Talang/
        public ActionResult Index()
        {
            var tal = new TalangModel {FirstName = "Felicia", LastName = "Joneby", Email = "felicia@joneby.com"};

            ViewBag.Message = tal.FirstName + tal.LastName + tal.Email;
            return View();
        }
	}
}