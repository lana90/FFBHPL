using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Fantasy.Models;

namespace Fantasy.Controllers
{
    public class UploadImageController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {

            UserCall.UserServiceClient data = new UserCall.UserServiceClient();
            foreach (string file in Request.Files)
            {
                HttpPostedFileBase hpf = Request.Files[file] as HttpPostedFileBase;
                if (hpf.ContentLength == 0)
                    continue;
                var fileName = Path.GetFileName(hpf.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/images"), fileName);
                hpf.SaveAs(path);
                data.InsertImage(path, model.UserName);
            }
            return RedirectToAction("Index", "UploadImage", new { mail = model.UserName });
        }
    }
}