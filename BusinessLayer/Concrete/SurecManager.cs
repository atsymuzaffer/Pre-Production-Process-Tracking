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
	public class SurecManager:ISurecService
	{
		private ISurecDal _SurecDal;
		public SurecManager(ISurecDal SurecDal)
		{
			_SurecDal = SurecDal;
		}
		public void SurecAdd(Surec surec)
		{
			throw new NotImplementedException();
		}

		public void SurecDelete(Surec surec)
		{
			throw new NotImplementedException();
		}

		public void SurecUpdate(Surec surec)
		{
			throw new NotImplementedException();
		}

		public List<Surec> GetList()
		{
			throw new NotImplementedException();
		}

		public Surec GetById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
