using System;
using System.Collections.Generic;
using System.Text;
using RishiBooks.Models;
using RishiBooks.DataAccess.Repository.IRepository;
using RishiBookStore.DataAccess.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RishiBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            // use .NET LINQ to retrieve the first or default category object
            // then pass the id as a generic entity which matches the Category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)          //Save Changes if not null
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }

        }
    }
}
