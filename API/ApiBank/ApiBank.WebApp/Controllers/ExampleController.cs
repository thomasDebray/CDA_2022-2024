using ClassLibraryModels;
using Microsoft.AspNetCore.Mvc;

namespace ApiBank.WebApp.Controllers
{
	public class ExampleController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult NamedView()
		{
			return View("MySuperView");
		}

		public IActionResult DataView()
		{
			ViewData["chaine1"] = "Voici une super chaîne de caractères !";

			ViewBag.chaine2 = "Voilà une autre chaîne, avec un chapeau !";

			return View();
		}

		public IActionResult ModelView()
		{
			BankTransaction transaction = new()
			{
				Transaction_Id = 22,
				Transaction_Date = DateTime.Now,
				Transaction_From = 123456789,
				Transaction_To = 987654321,
				Transaction_Amount = (decimal)999.45
			};
			return View(transaction);
		}
	}
}
