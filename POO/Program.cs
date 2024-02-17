using System;

namespace POO
{

    class Program
    {
        static void Main(string[] args)
        {
            Cerveceria oCerveceria = new Cerveceria();
            Cerveza oCerveza = new Cerveza();

            oCerveceria.Presentacion();
            oCerveza.Ingredientes();

        }
    }
}
 