namespace CapaEntidades
{
    public class clsJugadorEN
    {
        public string lStrNombre { get; set; }
        public int lIntCamisola { get; set; }
        public int lIntAmarillas { get; set; } = 0;
        public int lIntRojas { get; set; } = 0;
        public int lIntGoles { get; set; } = 0;

        public clsJugadorEN(string pStrNombre, int pIntCamisola) 
        {
            lStrNombre = pStrNombre;
            lIntCamisola = pIntCamisola;
        }

        public void fncIncrementarGoles()
        {
            lIntGoles++;
        }

        public void fncIncrementarGoles(int pIntGoles)
        {
            lIntGoles += pIntGoles;
        }

        public void fncIncrementarAmarillas()
        {
            lIntAmarillas++;
        }

        public void fncIncrementarAmarillas(int pIntAmarillas)
        {
            lIntRojas += pIntAmarillas;
        }

        public void fncIncrementarRojas()
        {
            lIntRojas++;
        }

        public void fncIncrementarRojas(int pIntRojas)
        {
            lIntRojas += pIntRojas;
        }

    }
}
