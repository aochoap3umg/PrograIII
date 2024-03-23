namespace TorneoRepasoPOO
{
    partial class frmEquipos
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
            lblNombreTorneo = new Label();
            lstEquipos = new ListBox();
            btnAgregarEquipo = new Button();
            txtNombreEquipo = new TextBox();
            label1 = new Label();
            btnClose = new Button();
            btnJugadores = new Button();
            SuspendLayout();
            // 
            // lblNombreTorneo
            // 
            lblNombreTorneo.AutoSize = true;
            lblNombreTorneo.Location = new Point(12, 9);
            lblNombreTorneo.Name = "lblNombreTorneo";
            lblNombreTorneo.Size = new Size(58, 15);
            lblNombreTorneo.TabIndex = 0;
            lblNombreTorneo.Text = "TORNEO: ";
            // 
            // lstEquipos
            // 
            lstEquipos.FormattingEnabled = true;
            lstEquipos.ItemHeight = 15;
            lstEquipos.Location = new Point(10, 125);
            lstEquipos.Name = "lstEquipos";
            lstEquipos.Size = new Size(256, 319);
            lstEquipos.TabIndex = 1;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.Location = new Point(142, 89);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(124, 30);
            btnAgregarEquipo.TabIndex = 2;
            btnAgregarEquipo.Text = "Agregar Equipo";
            btnAgregarEquipo.UseVisualStyleBackColor = true;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(10, 60);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(256, 23);
            txtNombreEquipo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 42);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 4;
            label1.Text = "Ingrese el nombre del Equipo:";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(143, 454);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(122, 30);
            btnClose.TabIndex = 5;
            btnClose.Text = "Salir";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnJugadores
            // 
            btnJugadores.Location = new Point(10, 454);
            btnJugadores.Name = "btnJugadores";
            btnJugadores.Size = new Size(122, 30);
            btnJugadores.TabIndex = 6;
            btnJugadores.Text = "Ingresar Jugadores";
            btnJugadores.UseVisualStyleBackColor = true;
            btnJugadores.Click += btnJugadores_Click;
            // 
            // frmEquipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 496);
            Controls.Add(btnJugadores);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(txtNombreEquipo);
            Controls.Add(btnAgregarEquipo);
            Controls.Add(lstEquipos);
            Controls.Add(lblNombreTorneo);
            Name = "frmEquipos";
            Text = "Equipos y Jugadores del Torneo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreTorneo;
        private ListBox lstEquipos;
        private Button btnAgregarEquipo;
        private TextBox txtNombreEquipo;
        private Label label1;
        private Button btnClose;
        private Button btnJugadores;
    }
}