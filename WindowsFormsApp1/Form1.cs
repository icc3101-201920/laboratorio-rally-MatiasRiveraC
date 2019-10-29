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
        public event EventHandler<AgregarPilotoEventArgs> OnAgregarPiloto;

        public Form1()
        {
            InitializeComponent();
            this.RolComboBox.DataSource = Enum.GetValues(typeof(Rol));
        }

        private void AgregarPilotoButton_Click(object sender, EventArgs e)
        {
            if (OnAgregarPiloto != null)
            {
                AgregarPilotoEventArgs pilotoArgs = new AgregarPilotoEventArgs();
                pilotoArgs.nombre = this.NameTextBox.Text;
                OnAgregarPiloto(this, pilotoArgs);
            }
               
        }

        public void ActualizarListadoPilotos(Persona pilotoNuevo)
        {
            PilotNameComboBox.Items.Add(pilotoNuevo);
        }

    }
}
