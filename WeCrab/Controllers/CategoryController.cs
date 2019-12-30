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
        private ApplicationDbContext _context;

        public CategoryController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Category
        public ActionResult Index()
        {
            var categoryModel = _context.Category.ToList();

            return View(categoryModel);
        }


        public ActionResult Details(int i)
        {
            var categoryId = _context.Category.SingleOrDefault(element => element.Id == i);
            return View(categoryId);
        }
    }
}