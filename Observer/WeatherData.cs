using System;
using System.Collections.Generic;
class WeatherData : Subject
{
    private List<Observer> observers;
    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData()
    {
        observers = new List<Observer>();
    }

    public void registerObserver(Observer o) => observers.Add(o);

    public void removeObserver(Observer o)
    {
        int i = observers.IndexOf(o);
        if (i >= 0)
        {
            observers.RemoveAt(i);
        }
    }

    public void notifyObservers()
    {
        observers.ForEach((o) => o.update(temperature, humidity, pressure));
    }

    public void measurementsChanged() => notifyObservers();

    public void setMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        measurementsChanged();
    }
}