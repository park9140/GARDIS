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
    public class UsersController : Controller
    {
        private GARDISContext context = new GARDISContext();

        //
        // GET: /Users/

        public ViewResult Index()
        {
            return View(context.Users.GetAll().ToList());
        }

        //
        // GET: /Users/Details/5

        public ViewResult Details(Norm.ObjectId id)
        {
            User user = context.Users.GetAll().Single(x => x.Id == id);
            return View(user);
        }

        //
        // GET: /Users/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Users/Create

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                context.Users.Insert(user);
                return RedirectToAction("Index");  
            }

            return View(user);
        }
        
        //
        // GET: /Users/Edit/5
 
        public ActionResult Edit(Norm.ObjectId id)
        {
            User user = context.Users.GetAll().Single(x => x.Id == id);
            return View(user);
        }

        //
        // POST: /Users/Edit/5

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                context.Users.Update(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        //
        // GET: /Users/Delete/5
 
        public ActionResult Delete(Norm.ObjectId id)
        {
            User user = context.Users.GetAll().Single(x => x.Id == id);
            return View(user);
        }

        //
        // POST: /Users/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Norm.ObjectId id)
        {
            User user = context.Users.GetAll().Single(x => x.Id == id);
            context.Users.Delete(user);
            return RedirectToAction("Index");
        }
    }
}