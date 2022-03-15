using BigJigSaw.Data;
using BigJigSaw.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigJigSaw.Controllers
{
    public class ItemController : Controller
    {

        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Item;
            return View(objList);
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj)
        {
            _db.Item.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Item.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }           

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Item.Find(id);
            if(obj == null)
            {
                return NotFound();
            }            
            
                _db.Item.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
          
        }

        
        public IActionResult Update(int? id)
        {           

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var item = _db.Item.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);

        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Item obj)
        {
            if (ModelState.IsValid)
            {
                _db.Item.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
    }

}

