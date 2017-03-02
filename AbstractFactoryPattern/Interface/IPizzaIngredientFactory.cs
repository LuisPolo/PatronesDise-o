using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;


/*ABSSSTRACTTTT FACTORYYYY*/

//Abstract Factory gives us an interface for creating a family of products
/*An abstract Factory provides an interface for a family of products. in this case all the ingredients necessary to
 make a pizza: daough, sauce, cheese, etc.*/

namespace FactoryPattern.Interface
{
    public  interface IPizzaIngredientFactory
    {

         Dough createDough();
         Sauce  createSauce();
         Cheese createCheese();
         Veggies[] createVeggie();
         Peperoni createPeperoni();
         Clams createClam();
    }
}
