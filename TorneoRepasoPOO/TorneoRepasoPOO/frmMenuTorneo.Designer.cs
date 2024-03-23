namespace TorneoRepasoPOO
{
    partial class frmMenuTorneo
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
            btnCrearTorneo = new Button();
            lblNombreTorneo = new Label();
            txtNombreTorneo = new TextBox();
            SuspendLayout();
            // 
            // btnCrearTorneo
            // 
            btnCrearTorneo.Location = new Point(64, 98);
            btnCrearTorneo.Name = "btnCrearTorneo";
            btnCrearTorneo.Size = new Size(168, 52);
            btnCrearTorneo.TabIndex = 0;
            btnCrearTorneo.Text = "Crear Torneo";
            btnCrearTorneo.UseVisualStyleBackColor = true;
            btnCrearTorneo.Click += btnCrearTorneo_Click;
            // 
            // lblNombreTorneo
            // 
            lblNombreTorneo.AutoSize = true;
            lblNombreTorneo.Location = new Point(24, 20);
            lblNombreTorneo.Name = "lblNombreTorneo";
            lblNombreTorneo.Size = new Size(162, 15);
            lblNombreTorneo.TabIndex = 1;
            lblNombreTorneo.Text = "Ingrese el nombre del torneo:";
            // 
            // txtNombreTorneo
            // 
            txtNombreTorneo.Location = new Point(24, 51);
            txtNombreTorneo.Name = "txtNombreTorneo";
            txtNombreTorneo.Size = new Size(249, 23);
            txtNombreTorneo.TabIndex = 2;
            // 
            // frmMenuTorneo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 186);
            Controls.Add(txtNombreTorneo);
            Controls.Add(lblNombreTorneo);
            Controls.Add(btnCrearTorneo);
            Name = "frmMenuTorneo";
            Text = "frmMenuTorneo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrearTorneo;
        private Label lblNombreTorneo;
        private TextBox txtNombreTorneo;
    }
}