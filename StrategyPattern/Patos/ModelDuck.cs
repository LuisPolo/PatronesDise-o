using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Segundo cambio realizado al proyecto de patrones

namespace StrategyPattern
{
    public class ModelDuck : Duck
    {

        public ModelDuck()
        {
            base.flyBehaviour = new FlyNoWay();
            base.quackBehaviour = new Quack();

        }

        public override void Display()
        {
            Console.WriteLine("I am a model duck");
        }
    }
}
