using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mallard");
            Mallard mallard = new Mallard();
            Helper(mallard);

            Console.ReadLine();
        }

        static void Helper(Duck pato)
        {
            pato.Swim();
            pato.DoFly();
            pato.DoQuack();
        }
    }
}