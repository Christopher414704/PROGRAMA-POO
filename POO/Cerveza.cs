using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Cerveza : Cerveceria
    {
        private decimal Cantidad_Agua = 3.4M;
        private decimal Cantidad_Cebada = 2.4M;
        private decimal Cantidad_Levadura = 1.7M;

        public void Ingredientes()
        {
            Console.WriteLine("Ingredientes:");
            Console.WriteLine("Agua: " + Cantidad_Agua + "mm");
            Console.WriteLine("Cebada: " + Cantidad_Cebada + "gm");
            Console.WriteLine("Levadura: " + Cantidad_Levadura + "gm");
        }
    }
}
