using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHelpDocumentService
    {
        List<HelpDocument> GetAllBL();
        List<HelpDocument> GetAllByHelpCategoriesId(int id);
        void AddBL(HelpDocument document);
        HelpDocument GetBL(int id);
        void HelpDocumentDelete(HelpDocument document);
        void HelpDocumentUpdate(HelpDocument document);
    }
}
