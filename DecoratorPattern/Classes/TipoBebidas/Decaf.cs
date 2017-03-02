using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecoratorPattern.Classes.BaseBebidas;

namespace DecoratorPattern.Classes.TipoBebidas
{
    public class Decaf : Beverage
    {

        public Decaf()
        {
            description = "Decaf coffee";
        } 

        
        public override double cost()
        {
            return 1.05;
        }

    }
}
