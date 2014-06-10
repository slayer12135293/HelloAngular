using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using angulardemo.domain.DomainModels;
using angulardemo.Models;

namespace angulardemo.Controllers
{
    public class CharacterListController : Controller
    {
        private SfDb db = new SfDb();

        //
        // GET: /CharacterList/

        public ActionResult Index()
        {
            return View(db.Chars.ToList());
        }

        //
        // GET: /CharacterList/Details/5

        public ActionResult Details(int id = 0)
        {
            Character character = db.Chars.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        //
        // GET: /CharacterList/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CharacterList/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Character character)
        {
            if (ModelState.IsValid)
            {
                db.Chars.Add(character);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(character);
        }

        //
        // GET: /CharacterList/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Character character = db.Chars.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        //
        // POST: /CharacterList/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Character character)
        {
            if (ModelState.IsValid)
            {
                db.Entry(character).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(character);
        }

        //
        // GET: /CharacterList/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Character character = db.Chars.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        //
        // POST: /CharacterList/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Character character = db.Chars.Find(id);
            db.Chars.Remove(character);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}