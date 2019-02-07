using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseUsingDapperCrud
{
	public class Teilnehmer
	{

		public int id_teilnehmer { get; set; }
		public string name { get; set; }
		public string vorname { get; set; }
		public DateTime geb_dat { get; set; }
		public string anmeld_num  { get; set; }
		public int kurs { get; set; }
		public string imageUrl { get; set; }


	}
}
