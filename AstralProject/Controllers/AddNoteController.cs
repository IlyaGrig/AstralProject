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
			NotesDbContext context = new NotesDbContext();
			context.Notes.Add(new Note(userId, nameNote, headerNote, textNote));
			context.SaveChanges();
			Note.UpdateFromCollection();
			return RedirectPermanent("~/MainPage");
	
		}      
    }
}