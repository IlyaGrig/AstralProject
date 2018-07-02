using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AstralProject.Models.TestClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AstralProject.Views.AddNote
{
    public class IndexModel : PageModel
    {
		public string Mes = "";
		public void OnGet()
		{
			Mes = "�������� �������";
		}
		public void OnPost(string nameNote, string headerNote, string textNote)
		{
		
			Mes = $"������� {nameNote} ���������";
		}
	}
}