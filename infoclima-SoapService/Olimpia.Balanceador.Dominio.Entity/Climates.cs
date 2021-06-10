using System;

namespace Olimpia.Balanceador.Dominio.Entity
{
	public class Climates
	{
		public int ClimaID { get; set; }
		public string Description { get; set; }
		public int Temperature { get; set; }
		public int Humidity { get; set; }
		public int Wind { get; set; }
		public string City { get; set; }
		public DateTime Date { get; set; }
	}
}