namespace CapaEntidades
{
    public class Persona
    {
        public string lStrNombre { get; set; }
        public int lIntEdad {  get; set; }

        public Persona(string pStrNombre, int pIntEdad)
        {
            this.lStrNombre = pStrNombre;
            this.lIntEdad = pIntEdad;
        }
    }
}
