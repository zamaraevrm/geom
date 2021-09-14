using Geom.Lib.Shapes.Line;
using System;

namespace cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Line ver = new VerticalLine(0, 0, 6);
            ver.Draw();
        }
    }
}
