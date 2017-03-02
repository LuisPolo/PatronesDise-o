using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FactoryPattern
{
    public abstract class Pizza
    {

        
        public String name, dough, sauce, veggies, cheese, peperoni, clams;
        public List<String>  toppings = new List<String>();


        //Antes el prepare escribia en consola todos los ingredientes ahora se ha hecho abstracto para que por tienda y estilo
        //podamos escoger los ingredientes

        public  void prepare()
        {

            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce... ");
            Console.WriteLine("Adding toppings: ");
            foreach (var topping in toppings)
            {
                Console.WriteLine("  " + topping);
            }
            
        }

        
        public virtual void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350 ");
        }

        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices ");
        }

        public virtual void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box ");
        }

        public string getName()
        {
            return name;
        }
    }
}
