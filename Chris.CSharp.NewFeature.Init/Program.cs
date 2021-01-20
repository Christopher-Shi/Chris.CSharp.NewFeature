using System;

namespace Chris.CSharp.NewFeature.Init
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = new WeatherObservation
            {
                RecordedAt = DateTime.Now,
                TemperatureInCelsius = 20,
                PressureInMillibars = 998.0m
            };

            Console.WriteLine("Hello World!");
        }
    }
}
