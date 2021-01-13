using System;

namespace Chris.CSharp.NewFeature.Partial
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCoords = new Coords(10, 15);
            myCoords.PrintCoords();

            Console.ReadKey();
        }
    }
}
