using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHelpCategoryService
    {
        List<HelpCategory> GetAllBL();
        void AddBL(HelpCategory category);
        HelpCategory GetBL(int id);
        void HelpCategoryDelete(HelpCategory category);
        void HelpCategoryUpdate(HelpCategory category);
    }
}
