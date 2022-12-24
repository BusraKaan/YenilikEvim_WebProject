using CodeFirst_Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace CodeFirst_Project1.Areas.AdminPanel.Controllers
{
    public class UserController : Controller
    {
        YenilikEvimModel db = new YenilikEvimModel();
        // GET: AdminPanel/User
        public ActionResult Index()
        {
            //Silinen kullanıcılar hariç kullanıcılar listelenir.
            return View(db.Users.Where(x => x.Deleted == false).ToList());
        }

        // GET: AdminPanel/User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminPanel/User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminPanel/User/Create
        [HttpPost]
        public ActionResult Create(System.Web.Mvc.FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminPanel/User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminPanel/User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, System.Web.Mvc.FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminPanel/User/Delete/5
        public ActionResult Delete(int id)
        {

            //try
            //{
            //    User u = db.Users.Find(id);
            //    u.Deleted = true;
            //    db.Entry(u).State = System.Data.Entity.EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //catch (Exception ex)
            //{
            //    ViewBag.error = "Bir hata oluştu." + ex.Message;
            //    return RedirectToAction("Index");
            //}
            return RedirectToAction("Index");

        }
        public JavaScriptResult javaScriptResult()
        {
            string js = @"alert('Alerttt');";
            return JavaScript(js);
        }

        // POST: AdminPanel/User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, System.Web.Mvc.FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
