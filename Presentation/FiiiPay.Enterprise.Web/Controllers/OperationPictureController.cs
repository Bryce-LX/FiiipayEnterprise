using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiiiPay.Enterprise.Web.Controllers
{
    public class OperationPictureController : BaseController
    {
        // GET: OperationPicture
        public ActionResult HomepageBanner()
        {
            return View();
        }


        public ActionResult FIIIEcologicalBanner()
        {
            return View();
        }

        public ActionResult NewsBanner()
        {
            return View();
        }
    }
}