using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Kullanici
	{
		[Key]
		public int KullaniciId { get; set; }
		public string KullaniciAdi { get; set; }
		public string KullaniciSoyadi { get; set; }
		public string Departman { get; set; }
		public int AdminStatu { get; set; }
		public bool Aktifmi { get; set; }
		public List<Surec> Surecs { get; set; }

	}
}
