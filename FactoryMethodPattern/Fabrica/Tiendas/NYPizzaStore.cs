using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryPattern.Fabrica;


namespace FactoryPattern
{
    public class NYPizzaStore : PizzaStore
    {

        public override Pizza createPizza(string type)
        {
            Pizza pizza;
            

            if (type.Equals("cheese"))
                pizza = new NYStyleCheesePizza();
            else if (type.Equals("greek"))
                pizza = new NYStyleGreekPizza();
            else if (type.Equals("peperoni"))
                pizza = new NYStylePeperoniPizza();
            else if (type.Equals("clam"))
                pizza = new NYStyleClamPizza();
            else if (type.Equals("veggie"))
                pizza = new NYStyleVeggiePizza();
            else
                pizza = new NYStylePeperoniPizza();
          

            return pizza;
        }
    }
}
