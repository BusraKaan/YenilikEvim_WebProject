using CodeFirst_Project1.Areas.AdminPanel.Filters;
using CodeFirst_Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst_Project1.Areas.AdminPanel.Controllers
{
    [AdminGirisKontrolAttribute]
    public class CategoryController : Controller
    {
        YenilikEvimModel db = new YenilikEvimModel();
        // GET: AdminPanel/Category
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        // GET: AdminPanel/Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminPanel/Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminPanel/Category/Create
        [HttpPost]
        public ActionResult Create(Category collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Categories.Add(collection);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    ViewBag.error = "Bir hata oluştu.";
                    return View();
                }
            }
            return View(collection);
        }

        // GET: AdminPanel/Category/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                Category c = db.Categories.Find(id);
                return View(c);
            }
            return RedirectToAction("Index");
        }

        // POST: AdminPanel/Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Category collection)
        {
            try
            {
                db.Entry(collection).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminPanel/Category/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                Category c = db.Categories.Find(id);
                return View(c);
            }
            return RedirectToAction("Index");
        }

        // POST: AdminPanel/Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Category collection)
        {
            try
            {
                db.Categories.Remove(collection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.error = "Bir hata oluştu."+ ex.Message;
                return View();
            }
        }
    }
}
