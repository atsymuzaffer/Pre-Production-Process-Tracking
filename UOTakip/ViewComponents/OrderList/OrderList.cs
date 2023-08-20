using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Newtonsoft.Json.Linq;

namespace UOTakip.ViewComponents.OrderList
{
	public class OrderList : ViewComponent
	{
		private OrderManager om = new OrderManager(new EfOrderRepository());

		public IViewComponentResult Invoke()
		{
			var values = om.GetList();
			return View(values);
		}

	}
}
