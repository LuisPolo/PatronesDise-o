using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecoratorPattern.Classes.BaseBebidas;
using DecoratorPattern.Classes.BaseDecorador;

namespace DecoratorPattern.Classes.Decoradores
{
    public class SteamedMilk : CondimentDecorator
    {
        


        public SteamedMilk(Beverage beverage): base(beverage)
        {

            

        }

      
        public override double cost()
        {
            return Bevy.cost() + 0.10;
        }

        public override string getDescription()
        {
            return Bevy.getDescription() + " , SteamedMilk";
        }
    }
}
