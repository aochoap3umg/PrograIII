using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArbol
{
    public class ArbolBinario
    {
        Nodo raiz;

        public ArbolBinario()
        {
            raiz = null;
        }

        public ArbolBinario(Nodo raiz)
        {   
            this.raiz = raiz; 
        }

        public Nodo raizArbol()
        {
            return raiz;
        }

        Boolean esVacio()
        {
            return raiz == null;
        }

        public static Nodo nuevoArbol (Nodo ramaIzqda, Object dato, Nodo ramaDrcha)
        {
            return new Nodo(ramaIzqda, dato, ramaDrcha);
        }

        public static int numNodos(Nodo raiz)
        {
            if (raiz == null)
                return 0;
            else
                return 1 + numNodos(raiz.subarbolDcho()) + numNodos(raiz.subarbolIzdo());
        }

        public static string preOrden(Nodo r)
        {
            if (r != null)
            {
                return r.visitar() + " - " + preOrden(r.subarbolIzdo()) + " - " + preOrden(r.subarbolDcho());
            }
            return "";
        }

        public static string enOrden(Nodo r)
        {
            if (r != null)
            {
                return enOrden(r.subarbolIzdo()) + " - " + r.visitar() + " - " + enOrden(r.subarbolDcho());
            }
            return "";
        }

        public static string postOrden(Nodo r)
        {
            if (r != null)
            {
                return enOrden(r.subarbolIzdo()) + " - " + enOrden(r.subarbolDcho()) + " - " + r.visitar();
            }
            return "";
        }
    }
}
