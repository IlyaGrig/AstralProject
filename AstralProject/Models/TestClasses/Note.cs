using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstralProject.Models.TestClasses
{
    public class Note
    {
		public static List<Note> GlobalNotes { get; } 
		public string NoteName { get; set; }
		public string HeaderNote { get; set; }
		public string TextNote { get; set; }
		public DateTime DateNote { get; set; }
	    static Note()
		{
			GlobalNotes = new List<Note>();
		}
		public Note(string noteName,string headerNote,string textNote)
		{
			NoteName = noteName;
			HeaderNote = headerNote;
			TextNote = textNote;
			DateNote = DateTime.Now;
		}

	}
}
