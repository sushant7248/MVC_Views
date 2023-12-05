using Microsoft.AspNetCore.Mvc;
using ViewsExample.Models;
using static ViewsExample.Models.Person;

namespace ViewsExample.Controllers
{
	public class HomeController : Controller
	{
		[Route("home")]

		[Route("/")]

		public IActionResult Index()
		{
			ViewData["appTitle"] = "Asp.Net Core Demo App";

			List<Person> people = new List<Person>()
				{
		  new Person() { Name = "John", DateOfBirth = DateTime.Parse("2000-05-06"), PersonGender = Gender.Male},
		  new Person() { Name = "Linda", DateOfBirth = DateTime.Parse("2005-01-09"), PersonGender = Gender.Female},
		  new Person() { Name = "Sushant", DateOfBirth = null, PersonGender = Gender.Male}
	  };

			return View("Index", people);
			//Views/Home/Index.cshtml
			//views/Home/index.cshtml
			//return View("abc"); //abc.cshtml
			//return new ViewResult() { ViewName = "abc" };
		}

		[Route("person-details/{name}")]
		public IActionResult Details(string? name)
		{

			if (name == null)

				return Content("person name cant be null");
			List<Person> people = new List<Person>()
			{
				new Person() { Name = "John", DateOfBirth = DateTime.Parse("2000-05-06"), PersonGender = Gender.Male },
				new Person() { Name = "Linda", DateOfBirth = DateTime.Parse("2005-01-09"), PersonGender = Gender.Female },
				new Person() { Name = "Sushant", DateOfBirth = null, PersonGender = Gender.Male }
			};
			Person matchperson =people.Where(temp => temp.Name == name).FirstOrDefault();
			return View(matchperson);
			//views/home/Details.cshtml
		}



	}
}
