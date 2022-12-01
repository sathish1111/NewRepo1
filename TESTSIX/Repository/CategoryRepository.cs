using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TESTSIX.Data;
using TESTSIX.Models;
using TESTSIX.Repository.IRepository;

namespace TESTSIX.Repository
{
   
    public class CategoryRepository : Repository<Category>, ICategory
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
         _db=db;
        }

        public void save()
        {
            _db.SaveChanges();
        }

        public void Update(Category obj)
        {
            _db.categories.Update(obj);
        }
    }
}
