using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanPharmacy.Models;

namespace UrbanPharmacy.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
