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

        [Route("HelpDocument/Index/{id}/{order}")]
        public ActionResult Index(int id,int order)
        {
            var helpdocumentvalues = hdm.GetAllByHelpCategoriesId(id);
            //helpdocumentvalues.Add(hdm.GetByOrder(order));
            //Console.WriteLine(helpdocumentvalues);
            ViewBag.id = id;
            ViewBag.order = order;
            return View(helpdocumentvalues);
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

        public ActionResult DeleteHelpDocument(int id)
        {
            var helpdocumentvalues = hdm.GetBL(id);
            hdm.HelpDocumentDelete(helpdocumentvalues);
            return RedirectToAction("GetHelpDocumentList");
        }

        [HttpGet]
        public ActionResult UpdateHelpDocument(int id)
        {
            var helpdocumentvalues = hdm.GetBL(id);
            return View(helpdocumentvalues);
        }

        [HttpPost]
        public ActionResult UpdateHelpDocument(HelpDocument entity)
        {
            hdm.HelpDocumentUpdate(entity);
            return RedirectToAction("GetHelpDocumentList");
        }

        public ActionResult GetAllByHelpCategoriesId(int id)
        {
            var helpdocumentvalues = hdm.GetAllByHelpCategoriesId(id);
            return View(helpdocumentvalues);
        }
        public ActionResult GetByTitle(string sentence)
        {
            var helpdocumentvalues = hdm.GetByTitle(sentence);
            return View(helpdocumentvalues);
        }
    }
}