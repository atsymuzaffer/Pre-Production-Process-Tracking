﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IOrderService
	{
		void OrderAdd(Order order);
		void OrderDelete(Order order);
		void OrderUpdate(Order order);
		List<Order> GetList();
		Order GetById(int id);
	}
}
