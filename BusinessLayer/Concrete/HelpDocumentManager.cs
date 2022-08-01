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

    }
}
