using CapaEntidades;
using EstructurasDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabListasEnlazadas1
{
    public partial class frmLaboratorioListas : Form
    {
        ListaEnlazada lObjListaPersonas;

        public frmLaboratorioListas()
        {
            InitializeComponent();
            lObjListaPersonas = new ListaEnlazada();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && nupEdad.Value > 0)
            {
                Persona lObjPersona = new Persona(txtNombre.Text, Convert.ToInt32(Math.Round(nupEdad.Value, 0)));
                lObjListaPersonas.fncInsertarEnCabeza(lObjPersona);
                MessageBox.Show(txtNombre.Text + " se ha guardado con exito");
                btnJoven.Enabled = true;
                btnViejo.Enabled = true;
                txtNombre.Text = "";
                nupEdad.Value = 0;
            }
            else
            {
                MessageBox.Show("Debe Ingresar el Nombre y la Edad de la Persona");
            }

        }

        private void btnJoven_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "La persona mas Joven es " + fncBuscarEnLista(btnJoven.Text);
        }

        private string fncBuscarEnLista(string pStrTipoEdad)
        {
            string lStrResult="Error al convertir";

            Nodo lObjAux = lObjListaPersonas.lObjPrimero;
            Persona lObjPersona;

            while(lObjAux != null)
            {
                lObjPersona= (Persona)(lObjAux.lObjDato);

                if (lObjAux.lObjEnlace != null) 
                { 
                    l
                }else
                {

                }
                
                lStrResult = lObjPersona.lStrNombre + " de " + lObjPersona.lIntEdad;

                lObjAux = lObjAux.lObjEnlace;
            }

            return lStrResult;
        }

    }
}
