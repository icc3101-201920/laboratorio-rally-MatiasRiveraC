using ModelosRally;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasRally
{
	public class AgregarEquipoEventArgs: EventArgs
	{
		public Persona piloto { get; set; }
		public Persona navegante { get; set; }
		public Vehiculo vehiculo { get; set; }
		public string nombre { get; set; }
	}
}
