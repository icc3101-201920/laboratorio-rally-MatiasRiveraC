using ModelosRally;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasRally
{
    public partial class Form1 : Form
    {
        public event EventHandler<AgregarPilotoEventArgs> OnAgregarPersona;
		public event EventHandler<AgregarNaveganteEventArgs> OnAgregarNavegante;
		public event EventHandler<AgregarVehiculoEventArgs> OnAgregarVehiculo;
		public event EventHandler<AgregarEquipoEventArgs> OnAgregarEquipo;
		public Form1()
        {
            InitializeComponent();
            this.RolComboBox.DataSource = Enum.GetValues(typeof(Rol));
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
			switch (RolComboBox.SelectedItem)
			{
				case Rol.Piloto:
				if (OnAgregarPersona != null)
				{
					AgregarPilotoEventArgs piloto = new AgregarPilotoEventArgs();
					piloto.nombre = this.NameTextBox.Text;
					OnAgregarPersona(this, piloto);
				 }
					break;
				case Rol.Navegante:
					if (OnAgregarNavegante != null)
					{
						AgregarNaveganteEventArgs navegante = new AgregarNaveganteEventArgs();
						navegante.nombre = this.NameTextBox.Text;
						OnAgregarNavegante(this, navegante);
					}
					break;
			}
			NameTextBox.Text = "";


		}

        public void ActualizarListado(Persona persona)
        {
            PilotNameComboBox.Items.Add(persona);
			switch (persona.GetRol())
			{
				case Rol.Piloto:
					PilotoComboBox.Items.Add(persona);
					break;
				case Rol.Navegante:
					NaveganteComboBox.Items.Add(persona);
					break;
			}
        }

		public void ActualizarEquipos(Equipo equipo)
		{
			EquiposComboBox.Items.Add(equipo);
		}


		private void EquipoStartButton_Click(object sender, EventArgs e)
		{
			EquipoPanel.Visible = true;
			
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			EquipoPanel.Visible = false;
		}

		private void AgregarVehiculoButton_Click(object sender, EventArgs e)
		{
			VehiculoPanel.Visible = true;
		}

		private void ExitVehiculoButton_Click(object sender, EventArgs e)
		{
			VehiculoPanel.Visible = false;
		}

		private void DoneVehiculoButton_Click(object sender, EventArgs e)
		{
			if (OnAgregarVehiculo != null)
			{
				AgregarVehiculoEventArgs vehiculo = new AgregarVehiculoEventArgs();
				vehiculo.marca = this.MarcaTextBox.Text;
				vehiculo.cilindrada = Convert.ToInt32(this.CilindradaUpDown.Value);
				OnAgregarVehiculo(this, vehiculo);
				VehiculoPanel.Visible = false;
			}
		}

		public void ActualizarVehiculos(Vehiculo vehiculo)
		{
			VehiculoComboBox.Items.Add(vehiculo);
		}

		private void EquipoButtonDone_Click(object sender, EventArgs e)
		{
			try
			{
				if (OnAgregarEquipo != null)
				{
					AgregarEquipoEventArgs equipo = new AgregarEquipoEventArgs();
					equipo.nombre = this.EquipoTextBox.Text;
					equipo.piloto = (Persona)this.PilotoComboBox.SelectedItem;
					equipo.navegante = (Persona)this.NaveganteComboBox.SelectedItem;
					equipo.vehiculo = (Vehiculo)this.VehiculoComboBox.SelectedItem;
					OnAgregarEquipo(this, equipo);
					EquipoPanel.Visible = false;
				}
			}
			catch
			{
				MessageBox.Show("Parametros incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void EquiposComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			Equipo equipo = (Equipo)EquiposComboBox.SelectedItem;
			LEquipo.Text = equipo.Nombre;
			LMarca.Text = equipo.Vehiculo.getMarca();
			LCilindrada.Text = equipo.Vehiculo.getCilindrada().ToString();
			LPiloto.Text = equipo.Piloto.GetNombre();
			LNavegante.Text = equipo.Navegante.GetNombre();
		}
	}
}
