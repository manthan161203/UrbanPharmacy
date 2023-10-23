using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanPharmacy.DataAccess.Data;
using UrbanPharmacy.DataAccess.Repository.IRepository;
using UrbanPharmacy.Models;

namespace UrbanPharmacy.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
