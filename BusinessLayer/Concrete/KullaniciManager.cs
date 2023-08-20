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
	public class KullaniciManager:IKullaniciService
	{
		private IKullaniciDal _kullaniciDal;

		public KullaniciManager(IKullaniciDal kullaniciDal)
		{
			_kullaniciDal = kullaniciDal;
		}
		public void KullaniciAdd(Kullanici kullanici)
		{
			throw new NotImplementedException();
		}

		public void KullaniciDelete(Kullanici kullanici)
		{
			throw new NotImplementedException();
		}

		public void KullaniciUpdate(Kullanici kullanici)
		{
			throw new NotImplementedException();
		}

		public List<Kullanici> GetList()
		{
			throw new NotImplementedException();
		}

		public Kullanici GetById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
