using MvcApplication1.Models;
using Operations.UserOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetUserInformation(string username)
        {
            HttpContext a = this.HttpContext.ApplicationInstance.Context;

            var Ip = HttpContext.Request.ServerVariables["REMOTE_ADDR"];
            var Ip2 = Request.ServerVariables["REMOTE_ADDR"];

            UserOperator userOperator =new UserOperator();
            string ipAddress = userOperator.ValidateIpAddress();

            User user = new User() 
            { 
                UserId=1, 
                UserName="Nipuna",
                IpAddress = ipAddress
            };

            return Json(user, JsonRequestBehavior.AllowGet);
        }
    }
}
