using System;
using System.Collections.Generic;
using DataAccesLayer;
using System.Linq;

namespace BusinessLogicLayer
{
	public class Search
	{
		public IEnumerable<Note> InListNote { get; set; }
		public string SearchText { get; set; }
		public Search(IEnumerable<Note> inListNote, string searchText)
		{
			InListNote = inListNote;
			if (searchText == null)
			{
				SearchText = "";
			}
			else { SearchText = searchText; }
		}

		public IEnumerable<Note> GetNotesFound()
		{
			return InListNote.Where(e => e.HeaderNote.Contains(SearchText) ||
										 e.NoteName.Contains(SearchText));
		}
	}
}
