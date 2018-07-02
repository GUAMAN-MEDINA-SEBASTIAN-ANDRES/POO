using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public interface IExplorable
    {
        void Modo();
        void Explorar();
        void Encontrar();
        void Esconderse();
        void Esquivar();
    }
}
