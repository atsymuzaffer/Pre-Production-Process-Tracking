using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ISurecService
	{
		void SurecAdd(Surec surec);
		void SurecDelete(Surec surec);
		void SurecUpdate(Surec surec);
		List<Surec> GetList();
		Surec GetById(int id);
	}
}
