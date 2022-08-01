using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repository
{
    public class HelpDocumentRepository:GenericRepository<HelpDocument>, IHelpDocumentDal
    {
    }
}
