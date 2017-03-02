using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryPattern.Interface;

namespace FactoryPattern
{
    public abstract class Pizza
    {

        public Dough dough;
        public Sauce sauce;
        public Veggies[] veggies;
        public Cheese cheese;
        public Peperoni peperoni;
        public Clams clams;


        public String name;

        //Antes el prepare escribia en consola todos los ingredientes ahora se ha hecho abstracto para que por tienda y estilo
        //podamos escoger los ingredientes

        public abstract void prepare();

        
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
