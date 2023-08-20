using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class StatuKategori
	{
		[Key]
		public int StatuKategoriId { get; set; }
		public string StatuKategoriAdi { get; set; }
		public bool Aktifmi { get; set; }

		public List<Surec> Surecs { get; set; }

	}
}
