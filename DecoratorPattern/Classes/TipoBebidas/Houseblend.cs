using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DecoratorPattern.Classes.BaseBebidas;

namespace DecoratorPattern.Classes.TipoBebidas
{
    public class HouseBlend : Beverage
    {

        public HouseBlend()
        {
            description = "HouseBlend coffee";
        } 

       
        public override double cost()
        {
            return 0.89;
        }
    }
}
