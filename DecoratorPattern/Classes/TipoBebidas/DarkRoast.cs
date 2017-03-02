using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecoratorPattern.Classes.BaseBebidas;

namespace DecoratorPattern.Classes.TipoBebidas
{
    public class DarkRoast : Beverage
    {
        
        public DarkRoast()
        {
            description = "DarkRoast coffee";
        }

        public override double cost()
        {
            return .99;
        }

    }
}
