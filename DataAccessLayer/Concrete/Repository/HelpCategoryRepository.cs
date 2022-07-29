using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repository
{
    public class HelpCategoryRepository : GenericRepository<HelpCategory>, IHelpCategoryDal
    {
        //Context context = new Context();
        //DbSet<HelpCategory> _object;

        //public void Delete(HelpCategory p)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Add(HelpCategory p)
        //{
        //    _object.Add(p);
        //    context.SaveChanges();
        //}

        //public List<HelpCategory> GetAll()
        //{
        //    return _object.ToList();
        //}

        //public void Update(HelpCategory p)
        //{
        //    context.SaveChanges();
        //}

        //public List<HelpCategory> Get(Expression<Func<HelpCategory, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}
        public void CategoryDeneme()
        {
            Console.WriteLine();
        }
    }
}
