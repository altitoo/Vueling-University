using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaDelTaxista
{
    
    public class Point
    {
        private readonly int _point1;
       
        private readonly int _point2;
       
        public Point(int x, int y)
        {
            _point1 = x;
            _point1 = y;
        }

        public ImmutableObject MyObject1 => new ImmutableObject(_point1);
        public ImmutableObject MyObject2 => new ImmutableObject(_point2);
    }
    
    public class ImmutableObject
    {
        private readonly int _num;
        public int Num => _num;

        public ImmutableObject(int num)
        {
            _num = num;
        }
    }
}
