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
	public class StatuKategoriManager:IStatuKategoriService
	{
		private IStatuKategoriDal _StatuKategoriDal;
		public StatuKategoriManager(IStatuKategoriDal StatuKategoriDal)
		{
			_StatuKategoriDal = StatuKategoriDal;
		}
		public void StatuKategoriAdd(StatuKategori statuKategori)
		{
			throw new NotImplementedException();
		}

		public void StatuKategoriDelete(StatuKategori statuKategori)
		{
			throw new NotImplementedException();
		}

		public void StatuKategoriUpdate(StatuKategori statuKategori)
		{
			throw new NotImplementedException();
		}

		public List<StatuKategori> GetList()
		{
			throw new NotImplementedException();
		}

		public StatuKategori GetById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
