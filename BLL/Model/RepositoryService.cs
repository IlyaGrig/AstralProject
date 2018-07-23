using AstralProject.Models.TestClasses;
using System;
using System.Collections.Generic;
using API;
using System.Linq;

namespace BLL.Model
{
    class RepositoryService : IRepository , IDisposable
    {
		private NotesDbContext db;

		public List<Note> NoteCollection { get ; set ; }

		public RepositoryService()
		{
			db = new NotesDbContext();
		}

		public IEnumerable<Note> GetNoteList()
		{
			return db.Notes.ToList();
		}

		public void DeleteNote(int id)
		{
			Note note = db.Notes.First(e => e.NoteId == id);
			if (note != null)
				db.Notes.Remove(note);
		}

		public void AddNote(string name, string header, string text, string userId)
		{
			Note newNote = new Note(userId,name,header,text);
			newNote.DateNote = DateTime.Now;
			newNote.Base64Icon = ApiIcon.GetIconBase64();
			db.Notes.Add(newNote);

		}

		public void UpdateNote(int id, string name, string header, string text)
		{
			Note note = db.Notes.First(e => e.NoteId == id);
			if (note != null)
				db.Notes.Remove(note);
				note.NoteName = name; note.HeaderNote = header; note.TextNote = text;
				note.DateNote = DateTime.Now;
				db.Notes.Add(note);
		}
		
		public void Save()
		{
			db.SaveChanges();
		}

		public void Dispose()
		{
			db.Dispose();
		}

		
	}
}
