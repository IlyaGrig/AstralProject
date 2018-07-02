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

		[HttpGet]
		public ActionResult HiNoname()
		{
			return View();
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
		public ActionResult SaveUpdate(int idNote,string userId,string base64Icon,string nameNote, string headerNote, string textNote)
		{
			Note upNote = new Note(userId,nameNote, headerNote, textNote);
			upNote.IdNote = idNote;
			upNote.DateNote = DateTime.Now;
			upNote.Base64Icon = base64Icon;
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