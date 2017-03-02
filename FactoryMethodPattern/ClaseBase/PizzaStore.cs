using System;

namespace FactoryPattern
{
    /*abstract creator class*/

    public abstract class PizzaStore
    {
        /*El metodo order pizza sabe lo que se hace con la pizza (prepare, bake, cut, box), pero no sabe exactamente
         como se hace, ya que pizza es abstracto. No tiene idea de que clases concretas estan involucradas.
         Esto es desacoplamiento
         */
        
      public Pizza orderPizza(string type)
        {
            Pizza pizza;


            pizza = this.createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;

        }


        /*Toda la responsabilidad de crear las pizzas se ha movido a un metodo que actua como fabrica.
         Un metodo de fabrica maneja la creacion del objeto y lo encapsula en una subclase. Esto desacopla 
         el codigo del cliente que esta en la superclase, del codigo de creacion del objeto en la subclase.
         1) Un metodo de fabrica es abstracto para dejar la responsabilidad de creacion del objeto en las subclases. 
         2) Un metodo de fabrica retorna un producto que es tipicamente usado dentro de metodos definidos en la superclase.
         3) Un metodo de fabrica aisla el cliente (el codigo en la superclase, como el orderPizza()) de conocer la informacion
         * de que tipo de producto concreto es creado.
         4) Un metodo de fabrica quiza sea parametrizable para seleccionar entre varias variaciones de un producto.
         */
        public abstract Pizza createPizza(String type);

    }
}
