using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASFY_Proyecto.Models
{
    public class BDD : Controller
    {
        // GET: BDD
        public ActionResult Index()
        {
            return View();
        }

        // GET: BDD/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BDD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BDD/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
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

        // GET: BDD/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BDD/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: BDD/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BDD/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
