using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    class PizzaTestDrive
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            var pizza = nyStore.orderPizza("cheese");
            Console.WriteLine("Luis order a " + pizza.getName() + "\n");

            pizza = chicagoStore.orderPizza("cheese");
            Console.WriteLine("Jorge order a " + pizza.getName() + "\n");

            

        }



        
    }
}
