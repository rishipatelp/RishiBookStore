using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RishiBooks.DataAccess.Repository.IRepository;
using RishiBookStore.Models;
using Microsoft.Extensions.Logging;
using RishiBooks.Models;

namespace RishiBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            Category category = new Category();
            if (id == null)
            {
                return View(category);

            }
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View();
        }

        //API calls here
        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            //return NotFound();
            var allobj = _unitOfWork.Category.GetAll();
            return Json(new { data = allobj });
        }
        #endregion
    }
}