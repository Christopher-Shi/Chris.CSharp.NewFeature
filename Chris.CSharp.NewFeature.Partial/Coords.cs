using System;

namespace Chris.CSharp.NewFeature.Partial
{
    public partial class Coords
    {
        private readonly int _x;
        private readonly int _y;

        public Coords(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }

    public partial class Coords
    {
        public void PrintCoords()
        {
            Console.WriteLine("Coords: {0},{1}", _x, _y);
        }

    }
}