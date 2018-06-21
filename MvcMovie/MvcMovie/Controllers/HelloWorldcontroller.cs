using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using MvcMovie;
using System.Threading.Tasks;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
	public class HelloWorldController : Controller
    {
		// GET: /HelloWorld/
		public IActionResult Index() => View();

		//GET: /HelloWorld/Welcome/
		public IActionResult Welcome(string name, int numTimes = 1)
		{
			ViewData["Message"] = "Hello" + name;
			ViewData["NumTimes"] = numTimes;
			return View();
		}
    }
}
