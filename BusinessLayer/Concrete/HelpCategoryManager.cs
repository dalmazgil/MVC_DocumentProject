using DataAccessLayer.Concrete.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HelpCategoryManager
    {
        HelpCategoryRepository repo = new HelpCategoryRepository();

        public void DenemeBL()
        {
            repo.CategoryDeneme();
        }

        public List<HelpCategory> GetAllBL()
        {
            return repo.GetAll();
        }

        public void HelpCategoryAddBL(HelpCategory entity)
        {
            if(entity.Description.Length == 0)
            {
                // hata mesajı
                // burası için ayrı bir dosya oluşturulacaktır.
            }
            else
            {
                repo.Add(entity);   
            }
        }

    }
}
