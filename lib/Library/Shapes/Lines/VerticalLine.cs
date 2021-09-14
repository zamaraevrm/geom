using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom.Lib.Shapes.Line
{
    public class VerticalLine: Line
    {
        public VerticalLine(int x, int y1, int y2)
        {
            if (y1 < 0 || y1 > y2 || x < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
                for (int i = y1; i <= y2; i++)
                {
                    Locus.Add(new(x, i));
                }
            
        }
    }
}
