using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class FooterController : Controller
    {
        //
        // GET: /Footer/
        public PartialViewResult Index()
        {
            TalangModel nam = new TalangModel { FirstName = "Felicia"};
            //PartialViewResult.me = "hej";
            return PartialView("Index", nam);
        }
	}
}