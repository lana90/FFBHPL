using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Fantasy.Controllers
{
    public class UploadImageController : Controller
    {

        //[HttpPost]
        public ActionResult Index()
        {
            foreach (string file in Request.Files)
            {
                HttpPostedFileBase hpf = Request.Files[file] as HttpPostedFileBase;
                if (hpf.ContentLength == 0)
                    continue;
                var fileName = Path.GetFileName(hpf.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/images"), fileName);
                hpf.SaveAs(path);
            }
            return View();
        }
    }

}
