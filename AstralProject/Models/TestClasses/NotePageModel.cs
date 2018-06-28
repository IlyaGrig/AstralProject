using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AstralProject.Models.TestClasses
{
    public class NotePageModel : PageModel
    {
		public string Message { get; set; }
		public void OnGet ()
		{
			Message = "Создание заметки";
		}
		public void OnPost(string nameNote,string headerNote,string textNote)
		{
		
			Note.GlobalNotes.Add(new Note(nameNote,headerNote,textNote));
			Message = $"Заметка {nameNote} добавлена";
		}
	}
}
