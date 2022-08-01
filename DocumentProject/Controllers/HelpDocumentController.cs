using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DocumentProject.Controllers
{
    public class HelpDocumentController : Controller
    {
        // GET: HelpCategory
        // Ders 29: Entity FrameworkDal

        HelpDocumentManager hdm = new HelpDocumentManager(new EfHelpDocumentDal());

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetHelpDocumentList()
        {
            var helpdocumentvalues = hdm.GetAllBL();
            return View(helpdocumentvalues);
        }

        [HttpGet]
        public ActionResult AddHelpDocument()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddHelpDocument(HelpDocument entity)
        {
            //hcm.HelpCategoryAddBL(entity);
            HelpDocumentValidator hdv = new HelpDocumentValidator();
            ValidationResult results = hdv.Validate(entity);
            if (results.IsValid)
            {
                hdm.AddBL(entity);
                return RedirectToAction("GetHelpDocumentList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}