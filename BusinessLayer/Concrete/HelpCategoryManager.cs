using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HelpCategoryManager:IHelpCategoryService
    {
        //HelpCategoryRepository repo = new HelpCategoryRepository();

        IHelpCategoryDal _categoryDal;

        public HelpCategoryManager(IHelpCategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddBL(HelpCategory category)
        {
            _categoryDal.Add(category);
        }

        public List<HelpCategory> GetAllBL()
        {
            return _categoryDal.GetAll();
        }


        //public void DenemeBL()
        //{
        //    repo.CategoryDeneme();
        //}

        //public void HelpCategoryAddBL(HelpCategory entity)
        //{
        //    if(entity.Description.Length == 0)
        //    {
        //        Console.WriteLine("Hata alındı");
        //        // hata mesajı
        //        // burası için ayrı bir dosya oluşturulacaktır.
        //    }
        //    else
        //    {
        //        repo.Add(entity);   
        //    }
        //}

    }
}
