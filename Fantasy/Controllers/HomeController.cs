using Fantasy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Fantasy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            UserCall.UserServiceClient data = new UserCall.UserServiceClient();

            if (ModelState.IsValid && data.IsValid(model.UserName, model.Password))
            {
                Session["LoggedUserID"] = model.UserName;
                FormsAuthentication.SetAuthCookie(model.UserName, true);

                return RedirectToAction("AfterLogin","Account");
            }
            else
            {
                ModelState.AddModelError("", "The user name or password provided is incorrect.");
                return View(model);
            }
         
            
           
        }
    }
}
