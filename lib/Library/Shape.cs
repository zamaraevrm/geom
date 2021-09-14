using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom.Lib
{
    public abstract class Shape:IEnumerable<Point>
    {
        public virtual IList<Point> Locus { get; set; } = new List<Point>();
        public void Draw()
        {
            foreach (var p in Locus) p.Draw();
        }

        public IEnumerator<Point> GetEnumerator()
        {
            return Locus.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Locus.GetEnumerator();

        }

       
    }
}
