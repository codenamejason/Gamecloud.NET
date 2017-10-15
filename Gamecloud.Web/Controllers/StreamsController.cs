using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gamecloud.Web.Controllers
{
    public class StreamsController : Controller
    {
        // GET: Streams
        public ActionResult Index()
        {
            return View();
        }

        // GET: Streams/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Streams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Streams/Create
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

        // GET: Streams/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Streams/Edit/5
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

        // GET: Streams/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Streams/Delete/5
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
