//using Uplift.DataAccess.Data.Repository.IRepository;

//namespace Uplift.DataAccess.Data.Repository
//{
//    public class UnitOfWork : IUnitOfWork
//    {
//        private readonly ApplicationDbContext _db;
//        public UnitOfWork(ApplicationDbContext db)
//        {
//            _db = db;
//            Category = new CategoryRepository(_db);
//        }
//        public ICategoryRepository Category { get; private set; }

//        public void Dispose()
//        {
//            _db.Dispose();
//        }

//        public void Save()
//        {
//            _db.SaveChanges();
//        }
//    }
//}
using Uplift.DataAccess.Data.Repository.IRepository;

namespace Uplift.DataAccess.Data.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }

        public ICategoryRepository Category { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}

