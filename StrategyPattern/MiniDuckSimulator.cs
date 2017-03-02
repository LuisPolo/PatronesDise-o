using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class MiniDuckSimulator
    {
        static void Main(string[] args)
        {   
            
            Duck Mallard = new MallardDuck();
            Mallard.performFly();
            Mallard.performQuack();

            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehaviour(new FlyWithWings());
            model.performFly();

            //no vuela
            Duck model2 = new ModelDuck();
            model.performFly();
            model.setFlyBehaviour(new FlyNoWay());
            model.performFly();

        }
    }
}
