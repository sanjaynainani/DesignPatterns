using System;

namespace Facade
{
    public interface ITemperatureService
    {
        LocalTemperature GetTemperature(double farenheit);
    }

    public class LocalTemperature
    {
        public double Celcius { get; set; }
        public double Farenheit { get; set; }
    }

    public class TemperatureService : ITemperatureService
    {
        readonly MetricConverterService _converter;

        public TemperatureService() : this(new MetricConverterService())
        { }

        public TemperatureService(MetricConverterService converter)
        {
            _converter = converter;
        }

        public LocalTemperature GetTemperature(double farenheit)
        {
            double celcius = _converter.FarenheitToCelcius(farenheit);
            LocalTemperature localTemperature = new LocalTemperature()
            {
                Farenheit = farenheit,
                Celcius = celcius,
            };

            return localTemperature;
        }
    }

    public class MetricConverterService
    {
        public double FarenheitToCelcius(double degrees)
        {
            return ((degrees - 32) / 9.0) * 5.0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const double temperature = 77.5;

            ITemperatureService temperatureService = new TemperatureService();
            LocalTemperature localTemp = temperatureService.GetTemperature(temperature);

            Console.WriteLine("The current temperature is {0}F/{1}C.",
                                localTemp.Farenheit.ToString("F1"),
                                localTemp.Celcius.ToString("F1"));

            Console.ReadKey();
        }
    }
}
