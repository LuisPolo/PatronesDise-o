﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Clases
{
    public class WeatherData : ISubject

    {

        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();

        }


        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void notifyObservers()
        {
            foreach (IObserver observer in observers)
                    observer.update(temperature, humidity, pressure);
            
        }

        public void meassurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            meassurementsChanged();
        }

    }
}
