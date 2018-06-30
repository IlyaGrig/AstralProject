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
     
        public ActionResult Index()
        {
			List<string> q = new List<string> { "1","sd" };
            return View(q);
        }

     
        
        [HttpPost]
		public ActionResult AddNewNote(string nameNote, string headerNote, string textNote)
		{
			Note.GlobalNotes.Add(new Note(nameNote, headerNote, textNote));
			// return RedirectPermanent("~/MainPge");
			return View("Index");
	
		}

	 
        
    }
}