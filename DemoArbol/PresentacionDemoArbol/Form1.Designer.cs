namespace PresentacionDemoArbol
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCrearArbol = new Button();
            btnNumNodos = new Button();
            txtResultado = new TextBox();
            btnPreOrden = new Button();
            btnEnOrden = new Button();
            btnPostOrden = new Button();
            SuspendLayout();
            // 
            // btnCrearArbol
            // 
            btnCrearArbol.Location = new Point(26, 35);
            btnCrearArbol.Name = "btnCrearArbol";
            btnCrearArbol.Size = new Size(167, 40);
            btnCrearArbol.TabIndex = 0;
            btnCrearArbol.Text = "Crear Arbol";
            btnCrearArbol.UseVisualStyleBackColor = true;
            btnCrearArbol.Click += btnCrearArbol_Click;
            // 
            // btnNumNodos
            // 
            btnNumNodos.Enabled = false;
            btnNumNodos.Location = new Point(249, 35);
            btnNumNodos.Name = "btnNumNodos";
            btnNumNodos.Size = new Size(167, 39);
            btnNumNodos.TabIndex = 1;
            btnNumNodos.Text = "Cantidad Nodos";
            btnNumNodos.UseVisualStyleBackColor = true;
            btnNumNodos.Click += btnNumNodos_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(26, 221);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(537, 114);
            txtResultado.TabIndex = 2;
            // 
            // btnPreOrden
            // 
            btnPreOrden.Enabled = false;
            btnPreOrden.Location = new Point(28, 142);
            btnPreOrden.Name = "btnPreOrden";
            btnPreOrden.Size = new Size(142, 48);
            btnPreOrden.TabIndex = 3;
            btnPreOrden.Text = "PreOrden";
            btnPreOrden.UseVisualStyleBackColor = true;
            btnPreOrden.Click += btnPreOrden_Click;
            // 
            // btnEnOrden
            // 
            btnEnOrden.Enabled = false;
            btnEnOrden.Location = new Point(229, 142);
            btnEnOrden.Name = "btnEnOrden";
            btnEnOrden.Size = new Size(142, 48);
            btnEnOrden.TabIndex = 3;
            btnEnOrden.Text = "EnOrden";
            btnEnOrden.UseVisualStyleBackColor = true;
            btnEnOrden.Click += btnEnOrden_Click;
            // 
            // btnPostOrden
            // 
            btnPostOrden.Enabled = false;
            btnPostOrden.Location = new Point(421, 142);
            btnPostOrden.Name = "btnPostOrden";
            btnPostOrden.Size = new Size(142, 48);
            btnPostOrden.TabIndex = 3;
            btnPostOrden.Text = "PostOrden";
            btnPostOrden.UseVisualStyleBackColor = true;
            btnPostOrden.Click += btnPostOrden_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 373);
            Controls.Add(btnPostOrden);
            Controls.Add(btnEnOrden);
            Controls.Add(btnPreOrden);
            Controls.Add(txtResultado);
            Controls.Add(btnNumNodos);
            Controls.Add(btnCrearArbol);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrearArbol;
        private Button btnNumNodos;
        private TextBox txtResultado;
        private Button btnPreOrden;
        private Button btnEnOrden;
        private Button btnPostOrden;
    }
}
