using Microsoft.AspNetCore.Mvc;

namespace UOTakip.Controllers
{
	public class AnaSayfa : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
