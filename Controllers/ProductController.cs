using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoGraviton.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoGraviton.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {

        private DataContext db = new DataContext();

        // GET: /<controller>/
        [Route("database")]
        public IActionResult Index()
        {
            ViewBag.products = db.Products.ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("database");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(string id)
        {
            db.Products.Remove(db.Products.Find(id));
            db.SaveChanges();
            return RedirectToAction("database");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(string id)
        {
            return View("Edit", db.Products.Find(id));
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(string id, Product product)
        {
            db.Entry(product).State =
                Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("database");
        }
    }
}
