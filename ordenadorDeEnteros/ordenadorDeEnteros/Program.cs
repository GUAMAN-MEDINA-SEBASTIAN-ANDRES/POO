using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenadorDeEnteros
{
    public class ordenadorEnteros
    {
        public int[] lista1 = { 5, 6, 9, 1, 0, 3, 7, 2, 4, 8 };
        int[] lista2 = { };

        public void Ordenar( int lista1)
        {
            var iMenor = 0;
            while (new List<int>().Count() > 0)
            {
                for (int i = 0; i < new List<int>().Count(); i++)
                {
                    if (new List<int>()[i] < new List<int>()[iMenor])
                    {
                        iMenor = i;
                    }
                }
                lista2.add(new List<int>()[iMenor]);
                new List<int>().Remove(iMenor);
            }
            return lista2;
        }
        public void Imprimir()
        {
            Console.WriteLine(value: Ordenar());
        }
    }
}
