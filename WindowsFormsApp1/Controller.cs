using ModelosRally;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasRally
{
    public class Controller
    {
        List<Persona> Pilotos;
		List<Persona> Navegantes;
		List<Equipo> equipo;
		Form1 mainForm;

        public Controller(Form1 vistaPilotos)
        {
			equipo = new List<Equipo>();
			Pilotos = new List<Persona>();
			Navegantes = new List<Persona>();
			this.mainForm = vistaPilotos;
            this.mainForm.OnAgregarPersona += VistaPilotos_OnAgregarPiloto;
			this.mainForm.OnAgregarNavegante += VistaNavegantes_OnAgregarNavegante;
			this.mainForm.OnAgregarVehiculo += AgregarVehiculo;
			this.mainForm.OnAgregarEquipo += AgregarEquipo;
		 }

        private void VistaPilotos_OnAgregarPiloto(object sender, AgregarPilotoEventArgs e)
        {
            Persona piloto = new Persona(e.nombre, Rol.Piloto);
            Pilotos.Add(piloto);
			mainForm.ActualizarListado(piloto);
        }

		private void VistaNavegantes_OnAgregarNavegante(object sender, AgregarNaveganteEventArgs e)
		{
			Persona navegante = new Persona(e.nombre, Rol.Navegante);
			Navegantes.Add(navegante);
			mainForm.ActualizarListado(navegante);
		}

		private void AgregarVehiculo(object sender, AgregarVehiculoEventArgs e)
		{
			Vehiculo vehiculo = new Vehiculo(e.marca, e.cilindrada);
			mainForm.ActualizarVehiculos(vehiculo);
		}

		private void AgregarEquipo(object sender, AgregarEquipoEventArgs e)
		{
			Equipo newEquipo = new Equipo(e.nombre, e.vehiculo, e.piloto, e.navegante);
			equipo.Add(newEquipo);
			mainForm.ActualizarEquipos(newEquipo);
		}


	}
}
