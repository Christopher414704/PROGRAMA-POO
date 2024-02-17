using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Cerveceria
    {

        public string Marca = "Gallo";
        public int Volume_alcohol = 17;

        
        public void Presentacion()
        {
            Console.WriteLine("Bebida Alcoholica:");
            Console.WriteLine(Marca);
            Console.WriteLine("Volumen Alcoho: " + Volume_alcohol + "%");
        }
    }
}
