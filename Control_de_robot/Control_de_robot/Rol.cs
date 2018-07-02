using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public class Asesino : IExplorable
    {
        public void Modo()
        {
            Console.WriteLine("\nAsesino");
        }

        public void Encontrar()
        {
            Console.WriteLine(" Encontrar armas");
        }

        public void Esconderse()
        {
            Console.WriteLine(" Encontrar lugar seguro para esconderse");
        }

        public void Esquivar()
        {
            Console.WriteLine(" Mantener los reflejos al limite");
        }

        public void Explorar()
        {
            Console.WriteLine(" Ver el lugar");
        }
    }

    public class Amistoso : IExplorable
    {
        public void Modo()
        {
            Console.WriteLine("\nAmistoso");
        }

        public void Encontrar()
        {
            Console.WriteLine(" Encontrar personas");
        }

        public void Esconderse()
        {
            Console.WriteLine(" No hay nesesidad de esconderse ");
        }

        public void Esquivar()
        {
            Console.WriteLine(" No hay nesesidad de esquivar ");
        }

        public void Explorar()
        {
            Console.WriteLine(" Ver el lugar");
        }
    }

    public class Precabido : IExplorable
    {
        public void Modo()
        {
            Console.WriteLine("\nPrecabido");
        }

        public void Encontrar()
        {
            Console.WriteLine(" Encontrar un lugar seguro");
        }

        public void Esconderse()
        {
            Console.WriteLine(" Esconderse en el lugar seguro");
        }

        public void Esquivar()
        {
            Console.WriteLine(" Mantenerse distancia");
        }

        public void Explorar()
        {
            Console.WriteLine(" Ver el lugar (con precaucion)");
        }
    }
}
