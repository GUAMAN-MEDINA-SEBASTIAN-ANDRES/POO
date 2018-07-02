using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Situacion");
            Aventura Desicion = new Aventura();
            Situacion(Desicion);

            Console.ReadLine();
        }

        static void Situacion(ROBOT robot)
        {
            robot.juego();
            robot.juego1();
            robot.juego2();
        }
    }
}