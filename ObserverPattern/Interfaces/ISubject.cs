using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.Interfaces
{
    public interface ISubject
    {

        void registerObserver(IObserver o);

        void removeObserver(IObserver o);

        void notifyObservers();


    }
}
