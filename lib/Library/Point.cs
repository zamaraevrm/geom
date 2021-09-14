using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Geom.Lib
{
    public struct Point
    {
        public int X, Y;

        public Point(int x, int y) : this()
        {
            X = x;
            Y = y;
        }

        const char Simbol = '*';

        public void Draw()
        {
            SetCursorPosition(X, Y);
            Write(Simbol);
        }
    }
}
