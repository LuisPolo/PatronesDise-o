using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryPattern.Interface;

namespace FactoryPattern.Fabrica
{
    public class NYStyleClamPizza:Pizza
    {

         public IPizzaIngredientFactory ingredientFactory;


         public NYStyleClamPizza(IPizzaIngredientFactory ingredientFactory)
        {

            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            throw new NotImplementedException();
        }
    }
}
