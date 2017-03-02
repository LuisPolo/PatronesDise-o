using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DecoratorPattern.Classes.BaseBebidas;

namespace DecoratorPattern.Classes.TipoBebidas
{
    public class Espresso: Beverage
    {

        public Espresso()
        {
            description = "Espresso coffee";
        } 


        public override double cost()
        {
            return 1.99;
        }
    }
}
