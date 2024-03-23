using System.ComponentModel;

namespace CapaEntidades
{
    public class clsTorneoEN
    {
        public string lStrNombre { get; set; }
        public clsEquipoEN[] lObjEquipos;
        public clsTorneoEN(string pStrNombre)
        {
            lStrNombre = pStrNombre;
            lObjEquipos = new clsEquipoEN[20];
        }

        public int fcnAgregarEquipo(string pStrNombre)
        {
            int lIntResult = -1;
            for (int i = 0; i < 20; i++)
            {
                if ( Object.ReferenceEquals(null,lObjEquipos[i]))
                {
                    lObjEquipos[i] = new clsEquipoEN(pStrNombre);
                    lIntResult = i;
                    break;
                }
            }
            return lIntResult;
        }

        public int fcnAgregarJugador(int pIntEquipo, string pStrNombre, int pIntCamisola)
        {
            int lIntResult = -1;
            for (int i = 0; i < 22; i++)
            {
                if (Object.ReferenceEquals(null, lObjEquipos[pIntEquipo].lObjJugadores[i]))
                {
                    lObjEquipos[pIntEquipo].lObjJugadores[i] = new clsJugadorEN(pStrNombre, pIntCamisola);
                    lIntResult = i;
                    break;
                }
            }
            return lIntResult;
        }
    }
}
