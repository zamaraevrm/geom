using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom.Lib.Shapes.Line
{
    public class HorisontalLine : Line
    {
        public HorisontalLine(int y, int x1, int x2)
        {
            for (int i = x1; i <= x2; i++)
            {
                Locus.Add(new(y, i));
            }
        }
    }
}
