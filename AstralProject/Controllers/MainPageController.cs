using BusinessLogicLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AstralProject.Controllers
{
    public class MainPageController : Controller
    {
		[HttpGet]
		public ActionResult Index()
		{
			using (RepositoryService rep = new RepositoryService())
			{
				return View(rep.GetNoteList());
			}
		}

		[HttpGet]
		public ActionResult HiNoname()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Search(string searchText)
		{
			using (RepositoryService rep = new RepositoryService())
			{
				return View(rep.Search(searchText));
			}

		}
		[HttpPost]
		public ActionResult Update(int idNote)
		{
			using (RepositoryService rep = new RepositoryService())
			{
				return View(rep.GetNote(idNote));
			}
		}

		[HttpPost]
		public ActionResult SaveUpdate(int idNote,string userId,string base64Icon,string nameNote, string headerNote, string textNote)
		{
			using (RepositoryService rep = new RepositoryService())
			{
				rep.UpdateNote(idNote,nameNote,headerNote,textNote);
				return RedirectPermanent("~/MainPage");
			}

		}

		[HttpPost]
		public ActionResult Delete(int idNote)
		{
			using (RepositoryService rep = new RepositoryService())
			{
				rep.DeleteNote(idNote);
				return View(rep.GetNoteList());
			}
		}
	}
}