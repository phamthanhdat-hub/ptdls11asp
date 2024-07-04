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
    public class PtdProductsController : Controller
    {
        private PtdK22CNT3Lesson11DbEntities db = new PtdK22CNT3Lesson11DbEntities();

        // GET: PtdProducts
        public ActionResult PtdIndex()
        {
            return View(db.PtdProduct.ToList());
        }

        // GET: PtdProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtdProduct ptdProduct = db.PtdProduct.Find(id);
            if (ptdProduct == null)
            {
                return HttpNotFound();
            }
            return View(ptdProduct);
        }

        // GET: PtdProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PtdProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Ptdid2210900007,PtdProName,PtdCty,PtdPrice,PtdCateId,PtdActive")] PtdProduct ptdProduct)
        {
            if (ModelState.IsValid)
            {
                db.PtdProduct.Add(ptdProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ptdProduct);
        }

        // GET: PtdProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtdProduct ptdProduct = db.PtdProduct.Find(id);
            if (ptdProduct == null)
            {
                return HttpNotFound();
            }
            return View(ptdProduct);
        }

        // POST: PtdProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Ptdid2210900007,PtdProName,PtdCty,PtdPrice,PtdCateId,PtdActive")] PtdProduct ptdProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptdProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ptdProduct);
        }

        // GET: PtdProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtdProduct ptdProduct = db.PtdProduct.Find(id);
            if (ptdProduct == null)
            {
                return HttpNotFound();
            }
            return View(ptdProduct);
        }

        // POST: PtdProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PtdProduct ptdProduct = db.PtdProduct.Find(id);
            db.PtdProduct.Remove(ptdProduct);
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
