using DemoArbol;

namespace PresentacionDemoArbol
{
    public partial class Form1 : Form
    {
        ArbolBinario miArbol;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            Nodo a1, a2, a;
            Nodo a11, a12, a21, a22;

            a11 = ArbolBinario.nuevoArbol(null, "Maria", null);
            a12 = ArbolBinario.nuevoArbol(null, "Rodrigo", null);
            a21 = ArbolBinario.nuevoArbol(null, "Anyora", null);
            a22 = ArbolBinario.nuevoArbol(null, "Abel", null);

            a1 = ArbolBinario.nuevoArbol(a11, "Alejandro", a12);
            a2 = ArbolBinario.nuevoArbol(a21, "Jesus", a22);
            a = ArbolBinario.nuevoArbol(a1, "Esperanza", a2);

            miArbol = new ArbolBinario(a);
            btnNumNodos.Enabled = true;
            btnPostOrden.Enabled = true;
            btnEnOrden.Enabled = true;
            btnPreOrden.Enabled = true;
        }

        private void btnNumNodos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El arbol tiene: " + ArbolBinario.numNodos(miArbol.raizArbol()) + " Nodos");
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtResultado.Text = ArbolBinario.preOrden(miArbol.raizArbol());
        }

        private void btnEnOrden_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtResultado.Text = ArbolBinario.enOrden(miArbol.raizArbol());
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtResultado.Text = ArbolBinario.postOrden(miArbol.raizArbol());
        }
    }
}
