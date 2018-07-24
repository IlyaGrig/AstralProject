using DataAccesLayer;
using System.Collections.Generic;
using System.Linq;

namespace AstralProject.Models.TestClasses
{
	public class SettingsSearch
	{
		public List<Note> InListNote { get; set; }
		public string SearchText { get; set; }
		public SettingsSearch(List<Note> inListNote, string searchText)
		{
			InListNote = inListNote;
			if (searchText == null)
			{
				SearchText = "";
			}
			else { SearchText = searchText; }
		}

		public IEnumerable<Note> Search ()
		{
			return  InListNote.Where(e => e.HeaderNote.Contains(SearchText));
													
		}
	}
}
