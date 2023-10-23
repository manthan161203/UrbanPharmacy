using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanPharmacy.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace UrbanPharmacy.DataAccess.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company obj);
    }
}
