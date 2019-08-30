using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASP_MVC_Entity_With_User_Registration.Models;

namespace ASP_MVC_Entity_With_User_Registration.Controllers
{
    public class Task2Controller : Controller
    {
        private ToDoModel db = new ToDoModel();

        // GET: Task2
        public ActionResult Index()
        {
            var task2s = db.Task2s.Include(t => t.Category1).Include(t => t.User);
            return View(task2s.ToList());
        }

        // GET: Task2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task2 task2 = db.Task2s.Find(id);
            if (task2 == null)
            {
                return HttpNotFound();
            }
            return View(task2);
        }

        // GET: Task2/Create
        public ActionResult Create()
        {
            ViewBag.Category = new SelectList(db.Categories, "CategoryID", "CategoryName");
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName");
            return View();
        }

        // POST: Task2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Task2ID,TaskDescription,Done,DateStarted,DateCompleted,Category,UserID,Deadline")] Task2 task2)
        {
            if (ModelState.IsValid)
            {
                db.Task2s.Add(task2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Category = new SelectList(db.Categories, "CategoryID", "CategoryName", task2.Category);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName", task2.UserID);
            return View(task2);
        }

        // GET: Task2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task2 task2 = db.Task2s.Find(id);
            if (task2 == null)
            {
                return HttpNotFound();
            }
            ViewBag.Category = new SelectList(db.Categories, "CategoryID", "CategoryName", task2.Category);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName", task2.UserID);
            return View(task2);
        }

        // POST: Task2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Task2ID,TaskDescription,Done,DateStarted,DateCompleted,Category,UserID,Deadline")] Task2 task2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(task2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Category = new SelectList(db.Categories, "CategoryID", "CategoryName", task2.Category);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName", task2.UserID);
            return View(task2);
        }

        // GET: Task2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task2 task2 = db.Task2s.Find(id);
            if (task2 == null)
            {
                return HttpNotFound();
            }
            return View(task2);
        }

        // POST: Task2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Task2 task2 = db.Task2s.Find(id);
            db.Task2s.Remove(task2);
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
