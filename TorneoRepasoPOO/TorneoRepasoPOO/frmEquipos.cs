using CapaEntidades;
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
    public partial class frmEquipos : Form
    {
        public frmEquipos()
        {
            //InitializeComponent();
        }

        public clsTorneoEN gObjTorneo;

        /// <summary>
        /// Metodo que inicializa
        /// </summary>
        /// <param name="pStrTorneo"></param>
        public frmEquipos(string pStrTorneo)
        {
            InitializeComponent();
            gObjTorneo = new clsTorneoEN(pStrTorneo);
            lblNombreTorneo.Text += pStrTorneo;
        }


        /// <summary>
        /// Metodo que almacena el dato ingresado a la lista enlazada
        /// </summary>
        public void fncAgregarEquipo()
        {
            if (txtNombreEquipo.Text != "")
            {
                int lIntPosicion = gObjTorneo.fcnAgregarEquipo(txtNombreEquipo.Text);
                if (lIntPosicion < 0)
                {
                    MessageBox.Show("Error en Almacenar el Equipo");
                }
                fncMostrarEquipos();
                txtNombreEquipo.Text = "";
                txtNombreEquipo.Focus();
            }
        }

        /// <summary>
        /// Metodo para Regenerar los elementos del listbox
        /// </summary>
        public void fncMostrarEquipos()
        {
            lstEquipos.Items.Clear();
            if (!Object.ReferenceEquals(null, gObjTorneo.lObjEquipos))
            {
                for (int i = 0; i < 20; i++)
                {
                    if (gObjTorneo.lObjEquipos[i] != null)
                    {
                        lstEquipos.Items.Add((i + 1) + " - " + gObjTorneo.lObjEquipos[i].lStrNombre);
                    }
                    else { break; }
                }
            }

        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            fncAgregarEquipo();
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            if (lstEquipos.SelectedItem != null)
            {
                frmJugador jugadores = new frmJugador(gObjTorneo, lstEquipos.SelectedIndex);
                jugadores.Show();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
