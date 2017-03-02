using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class FlyrocketPowered : IFlyBehaviour
    {
        public void fly()
        {
           Console.WriteLine("I am flying with a rocket !!!");
        }
    }
}
