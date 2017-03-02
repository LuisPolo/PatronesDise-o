using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    /*
     Concrete creator
     */
    
    public class CaliforniaPizzaStore : PizzaStore
    {


        public override Pizza createPizza(string type) 
        {
            Pizza pizza;

            if (type.Equals("cheese"))
                pizza = new CaliforniaStyleCheesePizza();
            else if (type.Equals("greek"))
                pizza = new CaliforniaStyleGreekPizza();
            else if (type.Equals("peperoni"))
                pizza = new CaliforniaStylePeperoniPizza();
            else if (type.Equals("clam"))
                pizza = new CaliforniaStyleClamPizza();
            else if (type.Equals("veggie"))
                pizza = new CaliforniaStyleVeggiePizza();
            else
                pizza = new CaliforniaStylePeperoniPizza();

            return pizza;
        }
    }
}
