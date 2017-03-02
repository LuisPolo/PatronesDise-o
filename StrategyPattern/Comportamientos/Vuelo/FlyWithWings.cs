using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I am flying!!");
        }
    }
}
