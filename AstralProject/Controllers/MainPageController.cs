using AstralProject.Models.TestClasses;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AstralProject.Controllers
{
    public class MainPageController : Controller
    {
		[HttpGet]
		public ActionResult Index()
		{ 
            return View(Note.GlobalNotes);
        }

		[HttpPost]
		public ActionResult Search(string searchText)
		{
			SettingsSearch settingsSearch = new SettingsSearch(Note.GlobalNotes, searchText);
			return View(settingsSearch.Search());

		}
		[HttpPost]
		public ActionResult Update(int idNote)
		{
			Note noteForUpdate = Repository.UpdateCollection(idNote);
			return View(noteForUpdate);
		}

		[HttpPost]
		public ActionResult SaveUpdate(int idNote,string nameNote, string headerNote, string textNote)
		{
			Note upNote = new Note(nameNote, headerNote, textNote);
			upNote.IdNote = idNote;
			upNote.DateNote = DateTime.Now;
			Repository.DeleteFromCollection(idNote);
			Note.GlobalNotes.Add(upNote);
			return RedirectPermanent("~/MainPage");

		}

		[HttpPost]
		public ActionResult Delete(int idNote)
		{
			Repository.DeleteFromCollection(idNote);
			return View(Note.GlobalNotes);
		}
	}
}