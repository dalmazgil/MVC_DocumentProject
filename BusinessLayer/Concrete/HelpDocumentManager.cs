using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HelpDocumentManager : IHelpDocumentService
    {
        IHelpDocumentDal _helpDocumentDal;

        public HelpDocumentManager(IHelpDocumentDal documentDal)
        {
            _helpDocumentDal = documentDal;
        }
        

        public void AddBL(HelpDocument document)
        {
            _helpDocumentDal.Add(document);
        }

        public List<HelpDocument> GetAllBL()
        {
            return _helpDocumentDal.GetAll();
        }

        public List<HelpDocument> GetAllByHelpCategoriesId(int id)
        {
            return _helpDocumentDal.List(x => x.HelpCategoriesId == id);
        }

        public HelpDocument GetBL(int id)
        {
            return _helpDocumentDal.Get(x => x.Id == id);
        }

        public void HelpDocumentDelete(HelpDocument document)
        {
            _helpDocumentDal.Delete(document);
        }

        public void HelpDocumentUpdate(HelpDocument document)
        {
            _helpDocumentDal.Update(document);
        }
    }
}
