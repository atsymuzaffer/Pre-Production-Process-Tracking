using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class OrderManager:IOrderService
	{


		private IOrderDal _orderDal;
		public OrderManager(IOrderDal OrderDal)
		{
			_orderDal = OrderDal;
		}
		public void OrderAdd(Order order)
		{
			_orderDal.Insert(order);
		}

		public void OrderDelete(Order order)
		{
			_orderDal.Delete(order);
		}

		public void OrderUpdate(Order order)
		{
			throw new NotImplementedException();
		}

		public List<Order> GetList()
		{
			return _orderDal.GetListAll();
		}

		public Order GetById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
