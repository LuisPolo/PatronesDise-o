using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public IFlyBehaviour flyBehaviour;
        public IQuackBehaviour quackBehaviour;

        public Duck()
        {
            
        }

        public abstract void Display();

        public void performFly()
        {
            flyBehaviour.fly();

        }

         public void performQuack()
        {
            quackBehaviour.quack();

        }

        public void swim()

        {
            Console.WriteLine("All duck float, even decoys!");

        }


        public void setFlyBehaviour(IFlyBehaviour fb)
        {
            this.flyBehaviour = fb;

        }

        public void setQuackBehaviour(IQuackBehaviour qb)
        {
            this.quackBehaviour = qb;

        }


    }
}
