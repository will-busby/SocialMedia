using SocialMediaApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaApp.Infrastructure
{
    public class GenericRepository<T>: IDisposable where T : class
    {
        protected ApplicationDbContext _db;
        public GenericRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        //void means we're not returning anything
        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
