using FactoryPattern.Fabrica;

namespace FactoryPattern
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza;

            if (type.Equals("cheese"))
                pizza = new ChicagoStyleCheesePizza();
            else if (type.Equals("greek"))
                pizza = new ChicagoStyleGreekPizza();
            else if (type.Equals("peperoni"))
                pizza = new ChicagoStylePeperoniPizza();
            else if (type.Equals("clam"))
                pizza = new ChicagoStyleClamPizza();
            else if (type.Equals("veggie"))
                pizza = new ChicagoStyleVeggiePizza();
            else
                pizza = new ChicagoStylePeperoniPizza();

            return pizza;
        }
    }
}
