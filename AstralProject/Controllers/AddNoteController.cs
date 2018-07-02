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
		public ActionResult AddNewNote(string userId,string nameNote, string headerNote, string textNote)
		{
			Note.GlobalNotes.Add(new Note(userId,nameNote, headerNote, textNote));
			return RedirectPermanent("~/MainPage");
	
		}      
    }
}