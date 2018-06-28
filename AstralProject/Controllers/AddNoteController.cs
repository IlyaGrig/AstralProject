using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AstralProject.Models.TestClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AstralProject.Controllers
{
    public class AddNoteController : Controller
    {
        // GET: AddNote
        public ActionResult Index()
        {			
            return View();
        }

        // GET: AddNote/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddNote/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddNote/Create
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

        // GET: AddNote/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddNote/Edit/5
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

        // GET: AddNote/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddNote/Delete/5
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