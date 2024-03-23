namespace TorneoRepasoPOO
{
    partial class frmJugador
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
            btnClose = new Button();
            lblNombreEquipo = new Label();
            txtNombreJugador = new TextBox();
            btnAgregarEquipo = new Button();
            lstJugadores = new ListBox();
            lblNombreTorneo = new Label();
            txtCamisola = new TextBox();
            lblNombreJugador = new Label();
            lblCamisola = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(144, 533);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(122, 30);
            btnClose.TabIndex = 12;
            btnClose.Text = "Regresar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblNombreEquipo
            // 
            lblNombreEquipo.AutoSize = true;
            lblNombreEquipo.Location = new Point(50, 33);
            lblNombreEquipo.Name = "lblNombreEquipo";
            lblNombreEquipo.Size = new Size(47, 15);
            lblNombreEquipo.TabIndex = 11;
            lblNombreEquipo.Text = "Equipo:";
            // 
            // txtNombreJugador
            // 
            txtNombreJugador.Location = new Point(10, 81);
            txtNombreJugador.Name = "txtNombreJugador";
            txtNombreJugador.Size = new Size(256, 23);
            txtNombreJugador.TabIndex = 10;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.Location = new Point(72, 139);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(124, 30);
            btnAgregarEquipo.TabIndex = 9;
            btnAgregarEquipo.Text = "Agregar Jugador";
            btnAgregarEquipo.UseVisualStyleBackColor = true;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // lstJugadores
            // 
            lstJugadores.FormattingEnabled = true;
            lstJugadores.ItemHeight = 15;
            lstJugadores.Location = new Point(12, 180);
            lstJugadores.Name = "lstJugadores";
            lstJugadores.Size = new Size(256, 349);
            lstJugadores.TabIndex = 8;
            // 
            // lblNombreTorneo
            // 
            lblNombreTorneo.AutoSize = true;
            lblNombreTorneo.Location = new Point(14, 11);
            lblNombreTorneo.Name = "lblNombreTorneo";
            lblNombreTorneo.Size = new Size(58, 15);
            lblNombreTorneo.TabIndex = 7;
            lblNombreTorneo.Text = "TORNEO: ";
            // 
            // txtCamisola
            // 
            txtCamisola.Location = new Point(144, 110);
            txtCamisola.Name = "txtCamisola";
            txtCamisola.Size = new Size(122, 23);
            txtCamisola.TabIndex = 13;
            // 
            // lblNombreJugador
            // 
            lblNombreJugador.AutoSize = true;
            lblNombreJugador.Location = new Point(12, 63);
            lblNombreJugador.Name = "lblNombreJugador";
            lblNombreJugador.Size = new Size(118, 15);
            lblNombreJugador.TabIndex = 14;
            lblNombreJugador.Text = "Nombre del Jugador:";
            // 
            // lblCamisola
            // 
            lblCamisola.AutoSize = true;
            lblCamisola.Location = new Point(14, 113);
            lblCamisola.Name = "lblCamisola";
            lblCamisola.Size = new Size(119, 15);
            lblCamisola.TabIndex = 15;
            lblCamisola.Text = "Numero de Camisola";
            // 
            // frmJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 566);
            Controls.Add(lblCamisola);
            Controls.Add(lblNombreJugador);
            Controls.Add(txtCamisola);
            Controls.Add(btnClose);
            Controls.Add(lblNombreEquipo);
            Controls.Add(txtNombreJugador);
            Controls.Add(btnAgregarEquipo);
            Controls.Add(lstJugadores);
            Controls.Add(lblNombreTorneo);
            Name = "frmJugador";
            Text = "frmJugador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label lblNombreEquipo;
        private TextBox txtNombreJugador;
        private Button btnAgregarEquipo;
        private ListBox lstJugadores;
        private Label lblNombreTorneo;
        private TextBox txtCamisola;
        private Label lblNombreJugador;
        private Label lblCamisola;
    }
}