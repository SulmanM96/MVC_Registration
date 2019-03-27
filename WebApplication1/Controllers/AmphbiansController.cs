using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1;

namespace WebApplication1.Controllers
{
    public class AmphbiansController : Controller
    {
        private AnimalDBEntities3 db = new AnimalDBEntities3();

        // GET: Amphbians
        public ActionResult Index()
        {
            return View(db.Amphbians.ToList());
        }//Get amphbian

        public ActionResult Search()
        {
            return View("Search");
        }

        //POST: Student/search/1
        [HttpPost]
        public ActionResult Search(int? id)
        {
            if (id == null)
            {
                return View("Error");
            }
            Amphbian amphbian = db.Amphbians.Find(id);
            if (amphbian == null)
            {
                return View("Error");
            }
            return View("Details", amphbian);
        
    }
        // GET: Amphbians/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("Error");
            }
            Amphbian amphbian = db.Amphbians.Find(id);
            if (amphbian == null)
            {
                return View("Error");
            }
            return View(amphbian);
        }

        // GET: Amphbians/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Amphbians/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Animal,SurviveOnLand,Pop,Dietry,AmphbiansID")] Amphbian amphbian)
        {
            if (ModelState.IsValid)
            {
                db.Amphbians.Add(amphbian);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(amphbian);
        }

        // GET: Amphbians/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Amphbian amphbian = db.Amphbians.Find(id);
            if (amphbian == null)
            {
                return HttpNotFound();
            }
            return View(amphbian);
        }

        // POST: Amphbians/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Animal,SurviveOnLand,Pop,Dietry,AmphbiansID")] Amphbian amphbian)
        {
            if (ModelState.IsValid)
            {
                db.Entry(amphbian).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(amphbian);
        }

        // GET: Amphbians/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Amphbian amphbian = db.Amphbians.Find(id);
            if (amphbian == null)
            {
                return HttpNotFound();
            }
            return View(amphbian);
        }

        // POST: Amphbians/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Amphbian amphbian = db.Amphbians.Find(id);
            db.Amphbians.Remove(amphbian);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
