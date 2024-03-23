using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    public class ListaEnlazada
    {
        public Nodo lObjPrimero;

        public ListaEnlazada()
        {
            this.lObjPrimero = null;
        }

        public ListaEnlazada fncInsertarEnCabeza(Object pObjNuevo)
        {
            Nodo lObjnuevo = new Nodo(pObjNuevo);
            lObjnuevo.lObjEnlace = this.lObjPrimero; 
            this.lObjPrimero = lObjnuevo;
            return this;
        }

    }
}
