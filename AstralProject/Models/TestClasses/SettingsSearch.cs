using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstralProject.Models.TestClasses
{
	public class SettingsSearch
	{
		public List<Note> InListNote { get; set; }
		public string SearchText { get; set; }
		public SettingsSearch(List<Note> inListNote, string searchText)
		{
			InListNote = inListNote;
			SearchText = searchText;
		}

		public IEnumerable<Note> Search ()
		{
			return  InListNote.Where(e => e.HeaderNote.Contains(SearchText));
													
		}
	}
}
