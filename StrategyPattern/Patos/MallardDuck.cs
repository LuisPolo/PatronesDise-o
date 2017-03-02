using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {


        public MallardDuck()
        {

            base.flyBehaviour = new FlyWithWings();
            base.quackBehaviour = new Quack();


        }


        public override void Display()
        {
           Console.WriteLine("I am a real Mallard Duck.");
        }
    }
}
