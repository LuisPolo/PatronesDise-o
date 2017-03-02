using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryPattern.Interface;

namespace FactoryPattern.Fabrica
{
    public class NYStyleVeggiePizza : Pizza
    {

          public IPizzaIngredientFactory ingredientFactory;


          public NYStyleVeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {

            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            throw new NotImplementedException();
        }
    }
}
