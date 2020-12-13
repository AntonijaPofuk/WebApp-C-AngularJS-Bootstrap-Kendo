using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class dbStudentsInfoesController : Controller
    {
        private StudentsEntities db = new StudentsEntities();

        // GET: dbStudentsInfoes
        public async Task<ActionResult> Index()
        {
            return View(await db.StudentsInfoes.ToListAsync());
        }

        // GET: dbStudentsInfoes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentsInfo studentsInfo = await db.StudentsInfoes.FindAsync(id);
            if (studentsInfo == null)
            {
                return HttpNotFound();
            }
            return View(studentsInfo);
        }

        // GET: dbStudentsInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: dbStudentsInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "StudentsName,StudentsYear,ID")] StudentsInfo studentsInfo)
        {
            if (ModelState.IsValid)
            {
                db.StudentsInfoes.Add(studentsInfo);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(studentsInfo);
        }

        // GET: dbStudentsInfoes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentsInfo studentsInfo = await db.StudentsInfoes.FindAsync(id);
            if (studentsInfo == null)
            {
                return HttpNotFound();
            }
            return View(studentsInfo);
        }

        // POST: dbStudentsInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "StudentsName,StudentsYear,ID")] StudentsInfo studentsInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentsInfo).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(studentsInfo);
        }

        // GET: dbStudentsInfoes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentsInfo studentsInfo = await db.StudentsInfoes.FindAsync(id);
            if (studentsInfo == null)
            {
                return HttpNotFound();
            }
            return View(studentsInfo);
        }

        // POST: dbStudentsInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            StudentsInfo studentsInfo = await db.StudentsInfoes.FindAsync(id);
            db.StudentsInfoes.Remove(studentsInfo);
            await db.SaveChangesAsync();
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
