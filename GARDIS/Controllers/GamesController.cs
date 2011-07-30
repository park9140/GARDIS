using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GARDIS.Models;

namespace GARDIS.Controllers
{   
    public class GamesController : Controller
    {
        private GARDISContext context = new GARDISContext();

        //
        // GET: /Games/

        public ViewResult Index()
        {
            return View(context.Games.GetAll().ToList());
        }

        //
        // GET: /Games/Details/5

        public ViewResult Details(Norm.ObjectId id)
        {
            Game game = context.Games.GetAll().Single(x => x.Id == id);
            return View(game);
        }

        //
        // GET: /Games/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Games/Create

        [HttpPost]
        public ActionResult Create(Game game)
        {
            if (ModelState.IsValid)
            {
                context.Games.Insert(game);
                return RedirectToAction("Index");  
            }

            return View(game);
        }
        
        //
        // GET: /Games/Edit/5
 
        public ActionResult Edit(Norm.ObjectId id)
        {
            Game game = context.Games.GetAll().Single(x => x.Id == id);
            return View(game);
        }

        //
        // POST: /Games/Edit/5

        [HttpPost]
        public ActionResult Edit(Game game)
        {
            if (ModelState.IsValid)
            {
                context.Games.Update(game);
                return RedirectToAction("Index");
            }
            return View(game);
        }

        //
        // GET: /Games/Delete/5
 
        public ActionResult Delete(Norm.ObjectId id)
        {
            Game game = context.Games.GetAll().Single(x => x.Id == id);
            return View(game);
        }

        //
        // POST: /Games/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Norm.ObjectId id)
        {
            Game game = context.Games.GetAll().Single(x => x.Id == id);
            context.Games.Delete(game);
            return RedirectToAction("Index");
        }
    }
}