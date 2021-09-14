using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom.Lib.Shapes.Line
{
    public abstract class Line: Shape
    {
        public bool IsHit(Line outher)
        {
            foreach(var innerp in Locus)
            {
                foreach(var outherp in outher.Locus)
                {
                    if (innerp.Is)
                }
            }
        }
    }
}
