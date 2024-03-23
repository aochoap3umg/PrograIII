namespace EstructurasDeDatos.ListaEnlazada
{
    public class clsNodo
    {
        object lObjDato;
        clsNodo lObjEnlace;

        public clsNodo(object pObjDato)
        {
            this.lObjDato = pObjDato;
            this.lObjEnlace = null;
        }

        public clsNodo(object pObjDato, clsNodo pObjEnlace )
        {
            this.lObjDato = pObjDato;
            this.lObjEnlace = pObjEnlace;
        }

    }
}
