using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneoRepasoPOO
{
    public partial class frmMenuTorneo : Form
    {
        public frmMenuTorneo()
        {
            InitializeComponent();
        }

        private void btnCrearTorneo_Click(object sender, EventArgs e)
        {
            if (txtNombreTorneo.Text != "")
            {
               frmEquipos equipo = new frmEquipos(txtNombreTorneo.Text);
                equipo.Show();
                this.Hide();
            }
        }
    }
}
