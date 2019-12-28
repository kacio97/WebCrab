using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeCrab.Models;

namespace WeCrab.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            var categoryModel = getCategories();

            return View(categoryModel);
        }

        private IEnumerable<Category> getCategories()
        {
            var categories = new List<Category>
            {
                new Category {Id = 1, Name = "Komedia"},
                new Category {Id = 2, Name = "Dramat"}
            };
            return categories;
        }

        public ActionResult Details(int i)
        {
            var categoryId = getCategories().SingleOrDefault(element => element.Id == i);
            return View(categoryId);
            
        }
    }
}