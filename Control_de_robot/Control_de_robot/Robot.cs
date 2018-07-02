using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public abstract class ROBOT
    {
        Precabido accion;
        Amistoso accion2;
        Asesino accion3;

        public void juego()
        {
            this.accion.Modo();
            this.accion.Explorar();
            this.accion.Encontrar();
            this.accion.Esconderse();
            this.accion.Esquivar();
        }

        public void juego1()
        {
            this.accion2.Modo();
            this.accion2.Explorar();
            this.accion2.Encontrar();
            this.accion2.Esconderse();
            this.accion2.Esquivar();
        }

        public void juego2()
        {
            this.accion3.Modo();
            this.accion3.Explorar();
            this.accion3.Encontrar();
            this.accion3.Esconderse();
            this.accion3.Esquivar();
        }

        public void Setjuego(Precabido newJuego)
        {
            this.accion = newJuego;
        }

        public void Setjuego1(Amistoso newJuego2)
        {
            this.accion2 = newJuego2;
        }

        public void Setjuego3(Asesino newJuego3)
        {
            this.accion3 = newJuego3;
        }
    }

    public class Aventura : ROBOT
    {
        public Aventura()
        {
            Setjuego(new Precabido());
            Setjuego1(new Amistoso());
            Setjuego3(new Asesino());
        }
    }
}
