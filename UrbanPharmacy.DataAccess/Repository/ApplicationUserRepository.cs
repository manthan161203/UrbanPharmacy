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
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
