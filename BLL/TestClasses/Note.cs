using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AstralProject.Models.TestClasses
{
    public class Note
    {
		public int NoteId { get; set; }
		static int i = 0;
		public static List<Note> GlobalNotes { get; set; }
		public string Base64Icon { get; set; }
		public int IdNote { get; set; }
		public string UserId { get; set; }
		public string NoteName { get; set; }
		public string HeaderNote { get; set; }
		public string TextNote { get; set; }
		public DateTime DateNote { get; set; }
	    static Note()
		{
			GlobalNotes = new List<Note>();
			UpdateFromDb();
		}

		public static void UpdateFromDb()
		{
			NotesDbContext context = new NotesDbContext();
			context.SaveChanges();
			foreach (var item in context.Notes)
			{
				GlobalNotes.Add(item);
			}
		}
		public static void UpdateFromCollection()
		{
			NotesDbContext context = new NotesDbContext();
			foreach (var item in context.Notes)
			{
				context.Notes.Remove(item);
			}
			foreach (var item in GlobalNotes)
			{
				context.Notes.Add(item);
			}
		}
		public Note(string userId,string noteName,string headerNote,string textNote)
		{
			i++;
			IdNote = i;
			UserId = userId;
			NoteName = noteName;
			HeaderNote = headerNote;
			TextNote = textNote;
			DateNote = DateTime.Now;
			Base64Icon = AddIcon(IdNote);
		}

		string AddIcon(int idNote)
		{
			string imgInString64 = "";
			using (var client = new HttpClient())
			{
				using (var response = client.GetStreamAsync($"https://avatars.dicebear.com/v2/identicon/{idNote}{NoteName}{DateNote}.svg").Result)
				{
					MemoryStream q = new MemoryStream();
					response.CopyTo(q);
					q.Seek(0,SeekOrigin.Begin);
					byte[] byteArray = new byte[q.Length];
				    q.ReadAsync(byteArray, 0, (int)q.Length);
					imgInString64 = Convert.ToBase64String(byteArray);
					
				}
			}
			return imgInString64;

		}

	}
}
