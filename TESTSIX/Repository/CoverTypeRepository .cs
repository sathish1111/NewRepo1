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
   
    public class CoverTypeRepository : Repository<CoverType>, ICoverType
    {
        private ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
         _db=db;
        }

        public void save()
        {
            _db.SaveChanges();
        }

        public void Update(CoverType obj)
        {
            _db.CoverTypes.Update(obj);
        }
    }
}
