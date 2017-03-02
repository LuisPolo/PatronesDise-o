using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using FactoryPattern.Interface;

namespace FactoryPattern.Fabrica.Ingredientes
{
    public class NyPizzaIngredientFactory : IPizzaIngredientFactory
    {
        


        public Dough createDough()
        {
            return new ThinCrustDough();
        }

        public Sauce createSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese createCheese()
        {
            return new ReggianoCheese();
        }

        public Veggies[] createVeggie()
        {

            Veggies[] veggies = {new Garlic(), new Onion(), new Mushrrom(), new RedPepper()};

            return veggies;
        }

        public Peperoni createPeperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams createClam()
        {
            return new FreshClams();
        }
    }
}
