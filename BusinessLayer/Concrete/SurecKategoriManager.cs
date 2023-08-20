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
	public class SurecKategoriManager:ISurecKategoriService
	{
		private ISurecKategoriDal _SurecKategoriDal;
		public SurecKategoriManager(ISurecKategoriDal SurecKategoriDal)
		{
			_SurecKategoriDal = SurecKategoriDal;
		}
		public void SurecKategoriAdd(SurecKategori surecKategori)
		{
			throw new NotImplementedException();
		}

		public void SurecKategoriDelete(SurecKategori surecKategori)
		{
			throw new NotImplementedException();
		}

		public void SurecKategoriUpdate(SurecKategori surecKategori)
		{
			throw new NotImplementedException();
		}

		public List<SurecKategori> GetList()
		{
			throw new NotImplementedException();
		}

		public SurecKategori GetById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
