using TESTSIX.Data;
using TESTSIX.Repository.IRepository;

namespace TESTSIX.Repository
{
    public class UnitofWork : IUnitofWork
    {
        public ICategory categoty { get;  private set; }

        public ICoverType coverType { get; private set; }

        private ApplicationDbContext _db;
        public UnitofWork(ApplicationDbContext db)
        {
            _db = db;
            categoty = new CategoryRepository(_db);
            coverType=new CoverTypeRepository(_db);
        }
        public void save()
        {
          _db.SaveChanges();
        }
    }
}
