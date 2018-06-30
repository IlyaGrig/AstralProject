using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstralProject.Models.TestClasses
{
    public interface IRepository 
	{
		List<Note> NoteCollection { get; set; }
		List<User> UserCollection { get; set; }
		IEnumerable<Note> UpdateCollection(Note note);
		IEnumerable<Note> DeleteFromCollection(Note note);
	}
}
