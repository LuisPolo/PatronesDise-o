using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryPattern.Fabrica;
using FactoryPattern.Fabrica.Ingredientes;
using FactoryPattern.Interface;

namespace FactoryPattern
{
    public class NYPizzaStore : PizzaStore
    {

        public override Pizza createPizza(string type)
        {
            Pizza pizza;

            IPizzaIngredientFactory ingredientFactory = new NyPizzaIngredientFactory();

            if (type.Equals("cheese"))
            {
                pizza = new NYStyleCheesePizza(ingredientFactory);
                pizza.name = "NY Style Cheese Pizza";
            }
            else if (type.Equals("greek"))
            {

                pizza = new NYStyleGreekPizza(ingredientFactory);
                pizza.name = "NY Style greek Pizza";

            }

            else if (type.Equals("peperoni"))
            {
                pizza = new NYStylePeperoniPizza(ingredientFactory);
                pizza.name = "NY Style peperoni Pizza";
            }
            else if (type.Equals("clam"))
            {
                pizza = new NYStyleClamPizza(ingredientFactory);
                pizza.name = "NY Style clam Pizza";
            }
            else if (type.Equals("veggie"))
            {
                pizza = new NYStyleVeggiePizza(ingredientFactory);
                pizza.name = "NY Style veggie Pizza";
            }
            else
            {
                pizza = new NYStylePeperoniPizza(ingredientFactory);
                pizza.name = "NY Style Cheese Pizza";
            }

            return pizza;
        }
    }
}
