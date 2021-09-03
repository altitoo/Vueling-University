using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaDelTaxista
{
    interface IDistanceMeasurement
    {
        public abstract int Calculate(Point p1, Point p2);
    }
}
