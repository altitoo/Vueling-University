using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaDelTaxista
{
    
    public class DistanceService : IDistanceMeasurement
    {
        public int Calculate(Point p1 , Point p2)
        {
            return p1.GetDistanceVector(p2) + p2.GetDistanceVector(p2);
        }
        
    }
}
