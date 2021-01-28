using System;

namespace Chris.CSharp.NewFeature.Init
{
    /// <summary>
    /// init 修饰的字段 只能在构造器中或者初始化器中被赋值
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            {
                var werWeatherObservation = new WeatherObservation
                {
                    RecordedAt = DateTime.Now,
                    TemperatureInCelsius = 20,
                    PressureInMillibars = 998.0m
                };

                Console.WriteLine(werWeatherObservation.ToString());

                // compiler error，不能对 init 的字段再赋值
                //werWeatherObservation.PressureInMillibars = 30;
            }

            {
                // Target-Typed new expression, C#9 新特性
                WeatherObservation p2 = new()
                {
                    RecordedAt = DateTime.Now,
                    TemperatureInCelsius = 20,
                    PressureInMillibars = 998.0m
                }, p3 = new()
                {
                    RecordedAt = DateTime.Now,
                    TemperatureInCelsius = 20,
                    PressureInMillibars = 998.0m
                };
                Console.WriteLine(p2);
                Console.WriteLine(p3);
            }

            Console.ReadLine();
        }
    }
}
