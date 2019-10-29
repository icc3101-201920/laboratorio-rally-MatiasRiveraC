namespace VistasRally
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.AgregarButton = new System.Windows.Forms.Button();
			this.PilotNameComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.RolComboBox = new System.Windows.Forms.ComboBox();
			this.EquipoPanel = new System.Windows.Forms.Panel();
			this.VehiculoLabel = new System.Windows.Forms.Label();
			this.VehiculoComboBox = new System.Windows.Forms.ComboBox();
			this.AgregarVehiculoButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.PilotoLabel = new System.Windows.Forms.Label();
			this.NaveganteLabel = new System.Windows.Forms.Label();
			this.EquipoLabel = new System.Windows.Forms.Label();
			this.EquipoButtonDone = new System.Windows.Forms.Button();
			this.EquipoTextBox = new System.Windows.Forms.TextBox();
			this.NaveganteComboBox = new System.Windows.Forms.ComboBox();
			this.PilotoComboBox = new System.Windows.Forms.ComboBox();
			this.EquipoStartButton = new System.Windows.Forms.Button();
			this.EquiposComboBox = new System.Windows.Forms.ComboBox();
			this.label = new System.Windows.Forms.Label();
			this.VehiculoPanel = new System.Windows.Forms.Panel();
			this.CilindradaLabel = new System.Windows.Forms.Label();
			this.MarcaTextBox = new System.Windows.Forms.TextBox();
			this.CilindradaUpDown = new System.Windows.Forms.NumericUpDown();
			this.MarcaLabel = new System.Windows.Forms.Label();
			this.DoneVehiculoButton = new System.Windows.Forms.Button();
			this.ExitVehiculoButton = new System.Windows.Forms.Button();
			this.LEquipo = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.LPiloto = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.LNavegante = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.LMarca = new System.Windows.Forms.Label();
			this.LCilindrada = new System.Windows.Forms.Label();
			this.EquipoPanel.SuspendLayout();
			this.VehiculoPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CilindradaUpDown)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(213, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(325, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bienvenidos a Rally Manager";
			// 
			// AgregarButton
			// 
			this.AgregarButton.Location = new System.Drawing.Point(164, 290);
			this.AgregarButton.Name = "AgregarButton";
			this.AgregarButton.Size = new System.Drawing.Size(124, 23);
			this.AgregarButton.TabIndex = 1;
			this.AgregarButton.Text = "Agregar";
			this.AgregarButton.UseVisualStyleBackColor = true;
			this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
			// 
			// PilotNameComboBox
			// 
			this.PilotNameComboBox.FormattingEnabled = true;
			this.PilotNameComboBox.Location = new System.Drawing.Point(161, 159);
			this.PilotNameComboBox.Name = "PilotNameComboBox";
			this.PilotNameComboBox.Size = new System.Drawing.Size(449, 21);
			this.PilotNameComboBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(161, 206);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(161, 236);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Rol";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(247, 206);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(363, 20);
			this.NameTextBox.TabIndex = 6;
			// 
			// RolComboBox
			// 
			this.RolComboBox.FormattingEnabled = true;
			this.RolComboBox.Location = new System.Drawing.Point(247, 236);
			this.RolComboBox.Name = "RolComboBox";
			this.RolComboBox.Size = new System.Drawing.Size(121, 21);
			this.RolComboBox.TabIndex = 7;
			// 
			// EquipoPanel
			// 
			this.EquipoPanel.Controls.Add(this.VehiculoLabel);
			this.EquipoPanel.Controls.Add(this.VehiculoComboBox);
			this.EquipoPanel.Controls.Add(this.AgregarVehiculoButton);
			this.EquipoPanel.Controls.Add(this.ExitButton);
			this.EquipoPanel.Controls.Add(this.PilotoLabel);
			this.EquipoPanel.Controls.Add(this.NaveganteLabel);
			this.EquipoPanel.Controls.Add(this.EquipoLabel);
			this.EquipoPanel.Controls.Add(this.EquipoButtonDone);
			this.EquipoPanel.Controls.Add(this.EquipoTextBox);
			this.EquipoPanel.Controls.Add(this.NaveganteComboBox);
			this.EquipoPanel.Controls.Add(this.PilotoComboBox);
			this.EquipoPanel.Location = new System.Drawing.Point(12, 319);
			this.EquipoPanel.Name = "EquipoPanel";
			this.EquipoPanel.Size = new System.Drawing.Size(481, 130);
			this.EquipoPanel.TabIndex = 8;
			this.EquipoPanel.Visible = false;
			// 
			// VehiculoLabel
			// 
			this.VehiculoLabel.AutoSize = true;
			this.VehiculoLabel.Location = new System.Drawing.Point(262, 11);
			this.VehiculoLabel.Name = "VehiculoLabel";
			this.VehiculoLabel.Size = new System.Drawing.Size(48, 13);
			this.VehiculoLabel.TabIndex = 10;
			this.VehiculoLabel.Text = "Vehiculo";
			// 
			// VehiculoComboBox
			// 
			this.VehiculoComboBox.FormattingEnabled = true;
			this.VehiculoComboBox.Location = new System.Drawing.Point(250, 36);
			this.VehiculoComboBox.Name = "VehiculoComboBox";
			this.VehiculoComboBox.Size = new System.Drawing.Size(95, 21);
			this.VehiculoComboBox.TabIndex = 9;
			// 
			// AgregarVehiculoButton
			// 
			this.AgregarVehiculoButton.Location = new System.Drawing.Point(250, 82);
			this.AgregarVehiculoButton.Name = "AgregarVehiculoButton";
			this.AgregarVehiculoButton.Size = new System.Drawing.Size(106, 23);
			this.AgregarVehiculoButton.TabIndex = 8;
			this.AgregarVehiculoButton.Text = "Agregar Vehiculo";
			this.AgregarVehiculoButton.UseVisualStyleBackColor = true;
			this.AgregarVehiculoButton.Click += new System.EventHandler(this.AgregarVehiculoButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(129, 82);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 23);
			this.ExitButton.TabIndex = 7;
			this.ExitButton.Text = "Salir";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// PilotoLabel
			// 
			this.PilotoLabel.AutoSize = true;
			this.PilotoLabel.Location = new System.Drawing.Point(14, 10);
			this.PilotoLabel.Name = "PilotoLabel";
			this.PilotoLabel.Size = new System.Drawing.Size(33, 13);
			this.PilotoLabel.TabIndex = 6;
			this.PilotoLabel.Text = "Piloto";
			// 
			// NaveganteLabel
			// 
			this.NaveganteLabel.AutoSize = true;
			this.NaveganteLabel.Location = new System.Drawing.Point(135, 11);
			this.NaveganteLabel.Name = "NaveganteLabel";
			this.NaveganteLabel.Size = new System.Drawing.Size(60, 13);
			this.NaveganteLabel.TabIndex = 5;
			this.NaveganteLabel.Text = "Navegante";
			// 
			// EquipoLabel
			// 
			this.EquipoLabel.AutoSize = true;
			this.EquipoLabel.Location = new System.Drawing.Point(368, 11);
			this.EquipoLabel.Name = "EquipoLabel";
			this.EquipoLabel.Size = new System.Drawing.Size(95, 13);
			this.EquipoLabel.TabIndex = 4;
			this.EquipoLabel.Text = "Nombre del Equpo";
			// 
			// EquipoButtonDone
			// 
			this.EquipoButtonDone.Location = new System.Drawing.Point(17, 82);
			this.EquipoButtonDone.Name = "EquipoButtonDone";
			this.EquipoButtonDone.Size = new System.Drawing.Size(75, 23);
			this.EquipoButtonDone.TabIndex = 3;
			this.EquipoButtonDone.Text = "Formar Equipo";
			this.EquipoButtonDone.UseVisualStyleBackColor = true;
			this.EquipoButtonDone.Click += new System.EventHandler(this.EquipoButtonDone_Click);
			// 
			// EquipoTextBox
			// 
			this.EquipoTextBox.Location = new System.Drawing.Point(371, 37);
			this.EquipoTextBox.Name = "EquipoTextBox";
			this.EquipoTextBox.Size = new System.Drawing.Size(100, 20);
			this.EquipoTextBox.TabIndex = 2;
			// 
			// NaveganteComboBox
			// 
			this.NaveganteComboBox.FormattingEnabled = true;
			this.NaveganteComboBox.Location = new System.Drawing.Point(129, 36);
			this.NaveganteComboBox.Name = "NaveganteComboBox";
			this.NaveganteComboBox.Size = new System.Drawing.Size(100, 21);
			this.NaveganteComboBox.TabIndex = 1;
			// 
			// PilotoComboBox
			// 
			this.PilotoComboBox.FormattingEnabled = true;
			this.PilotoComboBox.Location = new System.Drawing.Point(14, 35);
			this.PilotoComboBox.Name = "PilotoComboBox";
			this.PilotoComboBox.Size = new System.Drawing.Size(100, 21);
			this.PilotoComboBox.TabIndex = 0;
			// 
			// EquipoStartButton
			// 
			this.EquipoStartButton.Location = new System.Drawing.Point(303, 290);
			this.EquipoStartButton.Name = "EquipoStartButton";
			this.EquipoStartButton.Size = new System.Drawing.Size(96, 23);
			this.EquipoStartButton.TabIndex = 9;
			this.EquipoStartButton.Text = "Formar Equipo";
			this.EquipoStartButton.UseVisualStyleBackColor = true;
			this.EquipoStartButton.Click += new System.EventHandler(this.EquipoStartButton_Click);
			// 
			// EquiposComboBox
			// 
			this.EquiposComboBox.FormattingEnabled = true;
			this.EquiposComboBox.Location = new System.Drawing.Point(667, 159);
			this.EquiposComboBox.Name = "EquiposComboBox";
			this.EquiposComboBox.Size = new System.Drawing.Size(121, 21);
			this.EquiposComboBox.TabIndex = 10;
			this.EquiposComboBox.SelectedValueChanged += new System.EventHandler(this.EquiposComboBox_SelectedValueChanged);
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(9, 9);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(43, 13);
			this.label.TabIndex = 11;
			this.label.Text = "Equipo:";
			// 
			// VehiculoPanel
			// 
			this.VehiculoPanel.Controls.Add(this.ExitVehiculoButton);
			this.VehiculoPanel.Controls.Add(this.DoneVehiculoButton);
			this.VehiculoPanel.Controls.Add(this.MarcaLabel);
			this.VehiculoPanel.Controls.Add(this.CilindradaLabel);
			this.VehiculoPanel.Controls.Add(this.MarcaTextBox);
			this.VehiculoPanel.Controls.Add(this.CilindradaUpDown);
			this.VehiculoPanel.Location = new System.Drawing.Point(563, 316);
			this.VehiculoPanel.Name = "VehiculoPanel";
			this.VehiculoPanel.Size = new System.Drawing.Size(160, 108);
			this.VehiculoPanel.TabIndex = 12;
			this.VehiculoPanel.Visible = false;
			// 
			// CilindradaLabel
			// 
			this.CilindradaLabel.AutoSize = true;
			this.CilindradaLabel.Location = new System.Drawing.Point(4, 51);
			this.CilindradaLabel.Name = "CilindradaLabel";
			this.CilindradaLabel.Size = new System.Drawing.Size(53, 13);
			this.CilindradaLabel.TabIndex = 2;
			this.CilindradaLabel.Text = "Cilindrada";
			// 
			// MarcaTextBox
			// 
			this.MarcaTextBox.Location = new System.Drawing.Point(57, 25);
			this.MarcaTextBox.Name = "MarcaTextBox";
			this.MarcaTextBox.Size = new System.Drawing.Size(100, 20);
			this.MarcaTextBox.TabIndex = 1;
			// 
			// CilindradaUpDown
			// 
			this.CilindradaUpDown.Location = new System.Drawing.Point(104, 51);
			this.CilindradaUpDown.Name = "CilindradaUpDown";
			this.CilindradaUpDown.Size = new System.Drawing.Size(40, 20);
			this.CilindradaUpDown.TabIndex = 0;
			// 
			// MarcaLabel
			// 
			this.MarcaLabel.AutoSize = true;
			this.MarcaLabel.Location = new System.Drawing.Point(7, 25);
			this.MarcaLabel.Name = "MarcaLabel";
			this.MarcaLabel.Size = new System.Drawing.Size(37, 13);
			this.MarcaLabel.TabIndex = 3;
			this.MarcaLabel.Text = "Marca";
			// 
			// DoneVehiculoButton
			// 
			this.DoneVehiculoButton.Location = new System.Drawing.Point(7, 82);
			this.DoneVehiculoButton.Name = "DoneVehiculoButton";
			this.DoneVehiculoButton.Size = new System.Drawing.Size(64, 23);
			this.DoneVehiculoButton.TabIndex = 4;
			this.DoneVehiculoButton.Text = "Agregar";
			this.DoneVehiculoButton.UseVisualStyleBackColor = true;
			this.DoneVehiculoButton.Click += new System.EventHandler(this.DoneVehiculoButton_Click);
			// 
			// ExitVehiculoButton
			// 
			this.ExitVehiculoButton.Location = new System.Drawing.Point(90, 82);
			this.ExitVehiculoButton.Name = "ExitVehiculoButton";
			this.ExitVehiculoButton.Size = new System.Drawing.Size(62, 23);
			this.ExitVehiculoButton.TabIndex = 5;
			this.ExitVehiculoButton.Text = "Salir";
			this.ExitVehiculoButton.UseVisualStyleBackColor = true;
			this.ExitVehiculoButton.Click += new System.EventHandler(this.ExitVehiculoButton_Click);
			// 
			// LEquipo
			// 
			this.LEquipo.AutoSize = true;
			this.LEquipo.Location = new System.Drawing.Point(74, 9);
			this.LEquipo.Name = "LEquipo";
			this.LEquipo.Size = new System.Drawing.Size(69, 13);
			this.LEquipo.TabIndex = 13;
			this.LEquipo.Text = "DefaultName";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.LCilindrada);
			this.panel1.Controls.Add(this.LMarca);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.LNavegante);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.LPiloto);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label);
			this.panel1.Controls.Add(this.LEquipo);
			this.panel1.Location = new System.Drawing.Point(620, 186);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(178, 100);
			this.panel1.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Piloto:";
			// 
			// LPiloto
			// 
			this.LPiloto.AutoSize = true;
			this.LPiloto.Location = new System.Drawing.Point(74, 27);
			this.LPiloto.Name = "LPiloto";
			this.LPiloto.Size = new System.Drawing.Size(67, 13);
			this.LPiloto.TabIndex = 15;
			this.LPiloto.Text = "DefaultPiloto";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 43);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Navegante:";
			// 
			// LNavegante
			// 
			this.LNavegante.AutoSize = true;
			this.LNavegante.Location = new System.Drawing.Point(74, 43);
			this.LNavegante.Name = "LNavegante";
			this.LNavegante.Size = new System.Drawing.Size(94, 13);
			this.LNavegante.TabIndex = 17;
			this.LNavegante.Text = "DefaultNavegante";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(9, 58);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "Marca:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(9, 71);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 13);
			this.label10.TabIndex = 19;
			this.label10.Text = "Cilindrada:";
			// 
			// LMarca
			// 
			this.LMarca.AutoSize = true;
			this.LMarca.Location = new System.Drawing.Point(74, 61);
			this.LMarca.Name = "LMarca";
			this.LMarca.Size = new System.Drawing.Size(71, 13);
			this.LMarca.TabIndex = 20;
			this.LMarca.Text = "DefaultMarca";
			// 
			// LCilindrada
			// 
			this.LCilindrada.AutoSize = true;
			this.LCilindrada.Location = new System.Drawing.Point(74, 74);
			this.LCilindrada.Name = "LCilindrada";
			this.LCilindrada.Size = new System.Drawing.Size(87, 13);
			this.LCilindrada.TabIndex = 21;
			this.LCilindrada.Text = "DefaultCilindrada";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.VehiculoPanel);
			this.Controls.Add(this.EquiposComboBox);
			this.Controls.Add(this.EquipoStartButton);
			this.Controls.Add(this.EquipoPanel);
			this.Controls.Add(this.RolComboBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.PilotNameComboBox);
			this.Controls.Add(this.AgregarButton);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.EquipoPanel.ResumeLayout(false);
			this.EquipoPanel.PerformLayout();
			this.VehiculoPanel.ResumeLayout(false);
			this.VehiculoPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CilindradaUpDown)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.ComboBox PilotNameComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox RolComboBox;
		private System.Windows.Forms.Panel EquipoPanel;
		private System.Windows.Forms.ComboBox PilotoComboBox;
		private System.Windows.Forms.TextBox EquipoTextBox;
		private System.Windows.Forms.ComboBox NaveganteComboBox;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Label PilotoLabel;
		private System.Windows.Forms.Label NaveganteLabel;
		private System.Windows.Forms.Label EquipoLabel;
		private System.Windows.Forms.Button EquipoButtonDone;
		private System.Windows.Forms.Button EquipoStartButton;
		private System.Windows.Forms.Label VehiculoLabel;
		private System.Windows.Forms.ComboBox VehiculoComboBox;
		private System.Windows.Forms.Button AgregarVehiculoButton;
		private System.Windows.Forms.ComboBox EquiposComboBox;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Panel VehiculoPanel;
		private System.Windows.Forms.Label CilindradaLabel;
		private System.Windows.Forms.TextBox MarcaTextBox;
		private System.Windows.Forms.NumericUpDown CilindradaUpDown;
		private System.Windows.Forms.Button ExitVehiculoButton;
		private System.Windows.Forms.Button DoneVehiculoButton;
		private System.Windows.Forms.Label MarcaLabel;
		private System.Windows.Forms.Label LEquipo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label LCilindrada;
		private System.Windows.Forms.Label LMarca;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label LNavegante;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label LPiloto;
		private System.Windows.Forms.Label label5;
	}
}

