
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
            return View();
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
            return RedirectToAction("GetHelpCategoryList");
        }
    }
}