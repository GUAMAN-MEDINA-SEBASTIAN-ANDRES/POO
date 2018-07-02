using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickShort_Ordenamiento_
{
        class Inicio
        {
            static void Main()
            {
                int n;
                Console.WriteLine("Metodo de Quick Sort");
                Console.Write("Que cantidad de numeros va a tener? \n: ");
                n = Int32.Parse(Console.ReadLine());
                Llenar b = new Llenar(n);
            }
        }

        class Llenar
        {
            int h;
            int[] vector;
            public Llenar(int n)
            {
                h = n;
                vector = new int[h];
                for (int i = 0; i < h; i++)
                {
                    Console.Write("ingrese valor {0}: ", i + 1);
                    vector[i] = Int32.Parse(Console.ReadLine());
                }
                Quicksort(vector, 0, h - 1);
                Mostrar();
            }

            private void Quicksort(int[] vector, int primero, int ultimo)
            {
                int i, j, central;
                double pivote;
                central = (primero + ultimo) / 2;
                pivote = vector[central];
                i = primero;
                j = ultimo;
                do
                {
                    while (vector[i] < pivote) i++;
                    while (vector[j] > pivote) j--;
                    if (i <= j)
                    {
                        int temp;
                        temp = vector[i];
                        vector[i] = vector[j];
                        vector[j] = temp;
                        i++;
                        j--;
                    }
                } while (i <= j);

                if (primero < j)
                {
                    Quicksort(vector, primero, j);
                }
                if (i < ultimo)
                {
                    Quicksort(vector, i, ultimo);
                }
            }

            private void Mostrar()
            {
                Console.WriteLine("Vector ordenados en forma ascendente");
                for (int i = 0; i < h; i++)
                {
                    Console.Write("{0} ", vector[i]);
                }
                Console.ReadLine();
            }
        }
}
