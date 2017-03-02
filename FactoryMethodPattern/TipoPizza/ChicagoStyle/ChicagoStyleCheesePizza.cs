using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FactoryPattern.Fabrica
{
    public class ChicagoStyleCheesePizza : Pizza
    {

        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style deep dish cheese pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum tomatoe sauce";

            toppings.Add("Shredded Mozarella Cheese");

        }

       

        public override void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }

    }
}
