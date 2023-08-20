using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace UOTakip.Controllers
{
	public class OrderController : Controller
	{
		private OrderManager om = new OrderManager(new EfOrderRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Order o)
		{
			om.OrderAdd(o);
				return RedirectToAction("Index", "Order");
		}



	}
}
