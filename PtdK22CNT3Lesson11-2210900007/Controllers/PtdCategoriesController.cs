using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PtdK22CNT3Lesson11_2210900007.Models;

namespace PtdK22CNT3Lesson11_2210900007.Controllers
{
    public class PtdCategoriesController : Controller
    {
        private PtdK22CNT3Lesson11DbEntities db = new PtdK22CNT3Lesson11DbEntities();

        // GET: PtdCategories
        public ActionResult PtdIndex()
        {
            return View(db.PtdCategory.ToList());
        }

        // GET: PtdCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtdCategory ptdCategory = db.PtdCategory.Find(id);
            if (ptdCategory == null)
            {
                return HttpNotFound();
            }
            return View(ptdCategory);
        }

        // GET: PtdCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PtdCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PtdID,PtdCateName,PtdStatus")] PtdCategory ptdCategory)
        {
            if (ModelState.IsValid)
            {
                db.PtdCategory.Add(ptdCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ptdCategory);
        }

        // GET: PtdCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtdCategory ptdCategory = db.PtdCategory.Find(id);
            if (ptdCategory == null)
            {
                return HttpNotFound();
            }
            return View(ptdCategory);
        }

        // POST: PtdCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PtdID,PtdCateName,PtdStatus")] PtdCategory ptdCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptdCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ptdCategory);
        }

        // GET: PtdCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtdCategory ptdCategory = db.PtdCategory.Find(id);
            if (ptdCategory == null)
            {
                return HttpNotFound();
            }
            return View(ptdCategory);
        }

        // POST: PtdCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PtdCategory ptdCategory = db.PtdCategory.Find(id);
            db.PtdCategory.Remove(ptdCategory);
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
