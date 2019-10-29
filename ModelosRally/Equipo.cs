using System;
using System.Collections.Generic;

namespace ModelosRally
{
    public class Equipo
    {

        List<Vehiculo> vehiculos;
        List<Persona> tripulacion;

		private Persona piloto;
		private Persona navegante;
		private Vehiculo vehiculo;
		private string nombre;

		public Persona Piloto { get => piloto; set => piloto = value; }
		public Persona Navegante { get => navegante; set => navegante = value; }
		public Vehiculo Vehiculo { get => vehiculo; set => vehiculo = value; }
		public string Nombre { get => nombre; set => nombre = value; }

		public Equipo(string nombreInit, Vehiculo vehiculoInicial, Persona pilotoInit, Persona naveganteInit)
        {
            nombre = nombreInit;
			piloto = pilotoInit;
			vehiculo = vehiculoInicial;
			navegante = naveganteInit;

            vehiculos = new List<Vehiculo>();
            vehiculos.Add(vehiculoInicial);

            tripulacion = new List<Persona>();
            tripulacion.Add(piloto);
            tripulacion.Add(navegante);
        }

        public bool AgregarVehiculos(Vehiculo vehiculo)
        {
            //Agregar verificaciones
            vehiculos.Add(vehiculo);
            return true;
        }

        public List<Vehiculo> GetListaVehiculos()
        {
            return vehiculos;
        }

		public override string ToString()
		{
			return nombre;
		}

	}
}
