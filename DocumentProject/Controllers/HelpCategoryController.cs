
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System.Web.Mvc;

namespace DocumentProject.Controllers
{
    public class HelpCategoryController : Controller
    {
        // GET: HelpCategory
        // Ders 29: Entity FrameworkDal

        HelpCategoryManager hcm = new HelpCategoryManager(new EfHelpCategoryDal());

        public ActionResult Index()
        {
            var helpcategoryvalues = hcm.GetAllBL();
            return View(helpcategoryvalues);
        }

        public ActionResult GetHelpCategoryList()
        {
            var helpcategoryvalues = hcm.GetAllBL();
            return View(helpcategoryvalues);    
        }

        [HttpGet]
        public ActionResult AddHelpCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddHelpCategory(HelpCategory entity)
        {
            //hcm.HelpCategoryAddBL(entity);
            HelpCategoryValidator hcv = new HelpCategoryValidator();
            ValidationResult results = hcv.Validate(entity);
            if (results.IsValid)
            {
                hcm.AddBL(entity);
                return RedirectToAction("GetHelpCategoryList");
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

        public ActionResult DeleteHelpCategory(int id)
        {
            var helpcategoryvalues = hcm.GetBL(id);
            hcm.HelpCategoryDelete(helpcategoryvalues);
            return RedirectToAction("GetHelpCategoryList");
        }

        [HttpGet]
        public ActionResult UpdateHelpCategory(int id)
        {
            var helpcategoryvalues = hcm.GetBL(id);
            return View(helpcategoryvalues);
        }

        [HttpPost]
        public ActionResult UpdateHelpCategory(HelpCategory entity)
        {
            hcm.HelpCategoryUpdate(entity);
            return RedirectToAction("GetHelpCategoryList");
        }
    }
}