using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NicksDemoProject.Controllers
{
    public class HTMLController : Controller
    {
        //
        // GET: /HTML/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult test(List<string> list)
        {
            return null;
        }
    }
}
