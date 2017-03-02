using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecoratorPattern.Classes.BaseBebidas;
using DecoratorPattern.Classes.BaseDecorador;

namespace DecoratorPattern.Classes.Decoradores
{
    public class Soy : CondimentDecorator
    {
        


        public Soy(Beverage beverage): base(beverage)
        {
        }

     
        public override double cost()
        {
            return Bevy.cost() + 0.15;
        }

        public override string getDescription()
        {
            return Bevy.getDescription() + " , Soy";
        }
    }
}
