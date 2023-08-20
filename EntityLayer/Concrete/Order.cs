using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Order
	{
		[Key]
		public int OrderId { get; set; }
		public string OrderAdi { get; set; }
		public string ModelAdi { get; set; }
		public int Adet { get; set; }
		public string Musteri { get; set; }
		public string Ulke { get; set; }
		public string Yikamasi { get; set; }
		public DateTime TerminTarihi { get; set; }
		
		public byte QR { get; set; }
		public byte BarkodKod36 { get; set; }
		public bool Aktifmi { get; set; }

		public List<Surec> Surecs { get; set; }


	}
}
