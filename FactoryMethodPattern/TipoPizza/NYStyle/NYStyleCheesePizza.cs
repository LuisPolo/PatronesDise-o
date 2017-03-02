using System;


namespace FactoryPattern.Fabrica
{
    public class NYStyleCheesePizza : Pizza
    {

        public NYStyleCheesePizza()
        {
            name = "NY Style sauce and cheese pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara sauce";

            toppings.Add("Grated Reggiano Cheese");

        }

        
       
    }
}
