using System;
using RishiBooks.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RishiBooks.DataAccess.Repository.IRepository
{

    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }

}