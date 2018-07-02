using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hola
{
    public abstract class Duck
    {
        IFlyBehavior flyer;
        IQuackBehavior quacker;

        public void DoFly()
        {
            this.flyer.Fly();
        }

        public void SetFly(IFlyBehavior newFlyer)
        {
            this.flyer = newFlyer;
        }

        public void DoQuack()
        {
            this.quacker.Quack();
        }

        public void SetQuack(IQuackBehavior newQuacker)
        {
            this.quacker = newQuacker;
        }

        public virtual void Swim()
        {
            Console.WriteLine("Yo puedo nadar");
        }
    }

    public class Mallard : Duck
    {
        public Mallard()
        {
            SetFly(new FlyWithWings());
            SetQuack(new QuackLikeMallard());
        }
    }
}