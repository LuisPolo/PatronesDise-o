using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Singleton myclass = Singleton.getInstance();

            Singleton myclass2 = Singleton.getInstance();

            

        }
    }
}
