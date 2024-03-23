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
    public partial class frmJugador : Form
    {
        public frmJugador()
        {
            InitializeComponent();
        }

        public frmJugador(clsTorneoEN pObjTorneo, int pIntEquipo)
        {
            InitializeComponent();
            gObjTorneo = pObjTorneo;
            gIntEquipo = pIntEquipo;
            lblNombreTorneo.Text += pObjTorneo.lStrNombre;
            lblNombreEquipo.Text += pObjTorneo.lObjEquipos[pIntEquipo].lStrNombre;
        }

        clsTorneoEN gObjTorneo;
        int gIntEquipo;

        /// <summary>
        /// Metodo que almacena el dato ingresado a la lista enlazada
        /// </summary>
        public void fncAgregarJugador()
        {
            if (txtNombreJugador.Text != "" && txtCamisola.Text != "")
            {
                int lIntPosicion = gObjTorneo.fcnAgregarJugador(gIntEquipo, txtNombreJugador.Text, int.Parse(txtCamisola.Text));
                if (lIntPosicion < 0)
                {
                    MessageBox.Show("Error en Almacenar el Jugador");
                }
                fncMostrarJugadores();
                txtNombreJugador.Text = "";
                txtNombreJugador.Focus();
            }
        }

        /// <summary>
        /// Metodo para Regenerar los elementos del listbox
        /// </summary>
        public void fncMostrarJugadores()
        {
            lstJugadores.Items.Clear();
            if (!Object.ReferenceEquals(null, gObjTorneo.lObjEquipos[gIntEquipo].lObjJugadores))
            {
                for (int i = 0; i < 22; i++)
                {
                    if (gObjTorneo.lObjEquipos[gIntEquipo].lObjJugadores[i] != null)
                    {
                        lstJugadores.Items.Add(gObjTorneo.lObjEquipos[gIntEquipo].lObjJugadores[i].lIntCamisola + " - " + gObjTorneo.lObjEquipos[gIntEquipo].lObjJugadores[i].lStrNombre);
                    }
                    else { break; }
                }
            }

        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            fncAgregarJugador();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
