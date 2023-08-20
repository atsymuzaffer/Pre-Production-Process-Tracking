using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class SurecKategori
	{
		[Key]
		public int SurecKategoriId { get; set; }
		public string SurecKategoriAdi { get; set; }
		public bool Aktifmi { get; set; }

		public List<Surec> Surecs { get; set; }

	}
}
