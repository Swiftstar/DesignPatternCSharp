class CurrentConditionsDisplay : Observer, DisplayElement
{
    private float temperature;
    private float humidity;
    private Subject weatherData;

    public CurrentConditionsDisplay(Subject weatherData)
    {
        this.weatherData = weatherData;
        weatherData.registerObserver(this);
    }

    public void update(float temp, float humidity, float pressure)
    {
        this.temperature = temp;
        this.humidity = humidity;
        display();
    }

    public void display()
    {
        System.Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
    }
}