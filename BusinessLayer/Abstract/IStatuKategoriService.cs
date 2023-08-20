using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IStatuKategoriService
	{
		void StatuKategoriAdd(StatuKategori statuKategori);
		void StatuKategoriDelete(StatuKategori statuKategori);
		void StatuKategoriUpdate(StatuKategori statuKategori);
		List<StatuKategori> GetList();
		StatuKategori GetById(int id);
	}
}
