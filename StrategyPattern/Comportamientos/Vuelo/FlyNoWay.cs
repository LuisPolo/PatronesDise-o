using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class FlyNoWay:IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I cant fly :( .");
        }
    }
}
