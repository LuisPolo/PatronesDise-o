using DecoratorPattern.Classes.BaseBebidas;
using DecoratorPattern.Classes.BaseDecorador;

namespace DecoratorPattern.Classes.Decoradores
{
    public class Mocha : CondimentDecorator
    {
      

        public Mocha(Beverage beverage): base(beverage)
        {
           
        }

        
        public override double cost()
        {
            return Bevy.cost() + 0.20;
        }

        public override string getDescription()
        {
            return Bevy.getDescription() + " , Mocha";
        }
    }
}
