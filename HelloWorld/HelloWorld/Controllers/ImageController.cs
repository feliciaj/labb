using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{

    public class ImageController : Controller
    {



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FileUpload(HttpPostedFileBase file)
        {

            file.SaveAs(HttpContext.Server.MapPath("~/Images/") + file.FileName);

            DirectoryInfo dir = new DirectoryInfo(Server.MapPath(Url.Content("~/Images")));
            foreach (var file in dir.GetFiles())
            {
                list.Add(new Image() { ImagePath = file.Name });
            }


            // after successfully uploading redirect the user
            return RedirectToAction("Index", "Consultant");
        }
	}
}