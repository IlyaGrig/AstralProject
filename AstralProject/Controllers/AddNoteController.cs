using AstralProject.Models.TestClasses;
using Microsoft.AspNetCore.Mvc;

namespace AstralProject.Controllers
{
    public class AddNoteController : Controller
    {
     
        public ActionResult Index()
        {
            return View();
        }
		
        [HttpPost]
		public ActionResult AddNewNote(string nameNote, string headerNote, string textNote)
		{
			Note.GlobalNotes.Add(new Note(nameNote, headerNote, textNote));
			return RedirectPermanent("~/MainPage");
	
		}      
    }
}