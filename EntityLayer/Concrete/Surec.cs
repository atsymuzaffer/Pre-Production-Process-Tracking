using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Surec
	{
		[Key]
		public int SurecId { get; set; }
		//order
		public Order Order { get; set; }
		public int OrderId { get; set; }

		//sureckategori
		public SurecKategori SurecKategori { get; set; }
		public int SurecKategoriId { get; set; }

		//statukategori
		public StatuKategori StatuKategori { get; set; }
		public int StatuKategoriId { get; set; }

		public string Aciklama { get; set; }
		public string CihazAdi { get; set; }

		//kullanici
		public Kullanici Kullanici { get; set; }
		public int KullaniciId { get; set; }

		public DateTime Tarih1 { get; set; }
		public DateTime Tarih2 { get; set; }
		public string DosyaDevamEdenler { get; set; }
		public int BaslangicDurum { get; set; }
		public int BitisDurum { get; set; }
		public string HataMesaji { get; set; }

	}
}
