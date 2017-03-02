using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryPattern.Interface;

namespace FactoryPattern.Fabrica
{
    public class ClamPizza : Pizza
    {

        public IPizzaIngredientFactory ingredientFactory;


        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {

            this.ingredientFactory = ingredientFactory;
        }


        public override void prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            clams = ingredientFactory.createClam();
        }
    }
}
