using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverPattern.Clases;

namespace ObserverPattern
{
    class WeatherStation
    {

        static void Main(string[] args)
        {

            WeatherData weatherData = new WeatherData();
            
            CurrentConditionDisplay currentdDisplay = new CurrentConditionDisplay(weatherData);

            /*
             Se deberia poner el StatisticDisplay y  el ForecastDisplay
             
             *StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
             ForecastDisplay forecastDisplay = ForecastDisplay(weatherData);
              
             */

            HeatIndexDisplay heatDisplay = new HeatIndexDisplay(weatherData);

            weatherData.setMeasurements(80, 65 , 30.4f);
            weatherData.setMeasurements(82, 70, 29.2f);
            weatherData.setMeasurements(78, 90, 29.2f);

        }

    }
}
