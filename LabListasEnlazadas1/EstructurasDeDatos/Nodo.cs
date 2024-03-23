namespace EstructurasDeDatos
{
    public class Nodo
    {

        public Object lObjDato;
        public Nodo lObjEnlace;

        public Nodo(Object pObjDato)
        {
            this.lObjDato = pObjDato;
            this.lObjEnlace = null;
        }

    }
}
