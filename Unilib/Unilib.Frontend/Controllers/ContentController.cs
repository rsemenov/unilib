using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Unilib.Frontend.Controllers
{
    public class ContentController : Controller
    {
        //
        // GET: /Content/

        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase uploadFile)
        {

            return View();
        }

    }
}
