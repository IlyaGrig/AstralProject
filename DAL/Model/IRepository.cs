using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstralProject.Models.TestClasses
{
    public interface IRepository 
	{
		IEnumerable<Note> GetNoteList();
		void DeleteNote(int id);
		void AddNote( string name ,string header, string text, string userId);
		void UpdateNote(int id, string name, string header, string text);
	}
}
