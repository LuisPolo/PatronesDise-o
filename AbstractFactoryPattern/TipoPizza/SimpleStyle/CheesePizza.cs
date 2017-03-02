using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using FactoryPattern.Interface;


namespace FactoryPattern
{
    public class CheesePizza:Pizza
    {
        
        public IPizzaIngredientFactory ingredientFactory;


        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {

            this.ingredientFactory = ingredientFactory;
        }


        public override void prepare()
        {
            
            Console.WriteLine("Preparing " + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
        }

    }
}
