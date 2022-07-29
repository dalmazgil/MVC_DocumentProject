using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DocumentProject.Controllers
{
    public class HelpCategoryController : Controller
    {
        // GET: HelpCategory

        HelpCategoryManager hcm = new HelpCategoryManager();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetHelpCategoryList()
        {
            var helpcategoryvalues = hcm.GetAllBL();
            return View(helpcategoryvalues);    
        }
    }
}