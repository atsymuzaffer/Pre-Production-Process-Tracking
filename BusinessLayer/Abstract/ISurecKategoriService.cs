using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ISurecKategoriService
	{
		void SurecKategoriAdd(SurecKategori surecKategori);
		void SurecKategoriDelete(SurecKategori surecKategori);
		void SurecKategoriUpdate(SurecKategori surecKategori);
		List<SurecKategori> GetList();
		SurecKategori GetById(int id);
	}
}
