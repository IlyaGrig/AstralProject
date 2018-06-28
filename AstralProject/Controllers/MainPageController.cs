using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AstralProject.Controllers
{
    public class MainPageController : Controller
    {
        // GET: MainPage
        public ActionResult Index()
		{ 
            return View();
        }


		[HttpPost]
		public ActionResult AddNewNote(string searchText)
		{

			return null;

		}
	}
}