using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CUMobility.Controllers
{
    public class TestingController : Controller
    {
        // GET: Testing
        public String Index()
        {
            return "What is your problem?";
        }

        // GET: Testing/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Testing/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Testing/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Testing/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Testing/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Testing/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Testing/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}