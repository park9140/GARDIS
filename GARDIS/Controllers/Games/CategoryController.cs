using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GARDIS.Models.Properties.Game;
using GARDIS.Models;

namespace GARDIS.Controllers.Games
{   
    public class CategoryController : Controller
    {
        private GARDISContext context = new GARDISContext();

        //
        // GET: /Category/

        public ViewResult Index()
        {
            return View(context.GameCategories.GetAll().ToList());
        }

        //
        // GET: /Category/Details/5

        public ViewResult Details(Norm.ObjectId id)
        {
            Category category = context.GameCategories.GetAll().Single(x => x.Id == id);
            return View(category);
        }

        //
        // GET: /Category/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Category/Create

        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                context.GameCategories.Insert(category);
                return RedirectToAction("Index");  
            }

            return View(category);
        }
        
        //
        // GET: /Category/Edit/5
 
        public ActionResult Edit(Norm.ObjectId id)
        {
            Category category = context.GameCategories.GetAll().Single(x => x.Id == id);
            return View(category);
        }

        //
        // POST: /Category/Edit/5

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                context.GameCategories.Update(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }

        //
        // GET: /Category/Delete/5
 
        public ActionResult Delete(Norm.ObjectId id)
        {
            Category category = context.GameCategories.GetAll().Single(x => x.Id == id);
            return View(category);
        }

        //
        // POST: /Category/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Norm.ObjectId id)
        {
            Category category = context.GameCategories.GetAll().Single(x => x.Id == id);
            context.GameCategories.Delete(category);
            return RedirectToAction("Index");
        }
    }
}