using System;
using FactoryPattern.Interface;

namespace FactoryPattern.Fabrica
{
    public class NYStyleCheesePizza : Pizza
    {

        public IPizzaIngredientFactory ingredientFactory;


        public NYStyleCheesePizza(IPizzaIngredientFactory ingredientFactory)
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

        public override void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
