using System;
using System.Collections.Generic;
using System.Text;
using RishiBooks.Models;

namespace RishiBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
