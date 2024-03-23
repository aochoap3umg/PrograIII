using System.Security.Cryptography;

namespace CapaEntidades
{
    public class clsEquipoEN
    {
        public string lStrNombre { get; set; }
        public clsJugadorEN[] lObjJugadores { get; private set; }
        public clsEquipoEN(string pStrNombre) 
        {
            lStrNombre = pStrNombre;
            lObjJugadores = new clsJugadorEN[22];
        }
    }
}
