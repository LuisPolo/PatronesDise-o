using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryPattern.Fabrica;

namespace FactoryPattern
{
    public class PizzaStore
    {

        public SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory factory)
        {

            this.factory = factory;

        }

        Pizza orderPizza(string type)
        {
            Pizza pizza;


            pizza = factory.createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;

        }

    }
}
