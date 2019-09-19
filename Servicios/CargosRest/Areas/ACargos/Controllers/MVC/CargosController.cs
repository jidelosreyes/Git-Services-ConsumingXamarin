using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CargosRest.Areas.ACargos.Controllers.MVC
{
    public class CargosController : Controller
    {
        // GET: ACargos/Cargos
        public ActionResult Index()
        {
            return View();
        }

        // GET: ACargos/Cargos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ACargos/Cargos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ACargos/Cargos/Create
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

        // GET: ACargos/Cargos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ACargos/Cargos/Edit/5
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

        // GET: ACargos/Cargos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ACargos/Cargos/Delete/5
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
