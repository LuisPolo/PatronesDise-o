using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecoratorPattern.Classes.BaseBebidas;

namespace DecoratorPattern.Classes.BaseDecorador
{
    public abstract class CondimentDecorator : Beverage
    {
        private readonly Beverage _beverage;

        protected Beverage Bevy
        {
            get { return _beverage; }
        }

        protected CondimentDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }

    }


}
