using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IHelpCategoryDal:IGenericDal<HelpCategory>
    {
        // CRUD işlemleri için kontratlarımızı hazırlıyoruz.
        // Type Name();

        void CategoryDeneme();
    }
}
