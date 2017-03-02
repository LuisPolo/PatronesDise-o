using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class MuteQuack : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("<<Silence>>");
        }

    }
}
