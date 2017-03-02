using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ObserverPattern.Interfaces
{
    public interface IObserver
    {

        void update(float temp, float humidity, float pressure);

    }
}
