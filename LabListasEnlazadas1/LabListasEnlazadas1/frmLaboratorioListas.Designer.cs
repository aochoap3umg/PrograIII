namespace LabListasEnlazadas1
{
    partial class frmLaboratorioListas
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
            lblNombre = new Label();
            lblEdad = new Label();
            txtNombre = new TextBox();
            btnJoven = new Button();
            btnViejo = new Button();
            lblResultado = new Label();
            btnInsertar = new Button();
            lblMostrar = new Label();
            nupEdad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nupEdad).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(52, 42);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(110, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre Completo:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(52, 87);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 0;
            lblEdad.Text = "Edad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(168, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(205, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnJoven
            // 
            btnJoven.Enabled = false;
            btnJoven.Location = new Point(52, 175);
            btnJoven.Name = "btnJoven";
            btnJoven.Size = new Size(110, 23);
            btnJoven.TabIndex = 4;
            btnJoven.Text = "Joven";
            btnJoven.UseVisualStyleBackColor = true;
            btnJoven.Click += btnJoven_Click;
            // 
            // btnViejo
            // 
            btnViejo.Enabled = false;
            btnViejo.Location = new Point(253, 175);
            btnViejo.Name = "btnViejo";
            btnViejo.Size = new Size(120, 23);
            btnViejo.TabIndex = 5;
            btnViejo.Text = "Viejo";
            btnViejo.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(156, 213);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(110, 30);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(156, 126);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(104, 23);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "Ingresar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lblMostrar
            // 
            lblMostrar.AutoSize = true;
            lblMostrar.Font = new Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrar.Location = new Point(12, 251);
            lblMostrar.Name = "lblMostrar";
            lblMostrar.Size = new Size(0, 21);
            lblMostrar.TabIndex = 7;
            // 
            // nupEdad
            // 
            nupEdad.Location = new Point(168, 79);
            nupEdad.Name = "nupEdad";
            nupEdad.Size = new Size(205, 23);
            nupEdad.TabIndex = 2;
            // 
            // frmLaboratorioListas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 281);
            Controls.Add(nupEdad);
            Controls.Add(lblMostrar);
            Controls.Add(btnInsertar);
            Controls.Add(lblResultado);
            Controls.Add(btnViejo);
            Controls.Add(btnJoven);
            Controls.Add(txtNombre);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Name = "frmLaboratorioListas";
            Text = "Edades";
            ((System.ComponentModel.ISupportInitialize)nupEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblEdad;
        private TextBox txtNombre;
        private Button btnJoven;
        private Button btnViejo;
        private Label lblResultado;
        private Button btnInsertar;
        private Label lblMostrar;
        private NumericUpDown nupEdad;
    }
}