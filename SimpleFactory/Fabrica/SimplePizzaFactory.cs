using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern.Fabrica
{
    public class SimplePizzaFactory
    {

        public Pizza createPizza(string type)
        {
            Pizza pizza;

            if (type.Equals("cheese"))
                pizza = new CheesePizza();
            else if (type.Equals("greek"))
                pizza = new GreekPizza();
            else if (type.Equals("peperoni"))
                pizza = new PeperoniPizza();
            else if (type.Equals("clam"))
                pizza = new ClamPizza();
            else if (type.Equals("veggie"))
                pizza = new VeggiePizza();
            else
                pizza = new PeperoniPizza();

            return pizza;

        }

    }
}
