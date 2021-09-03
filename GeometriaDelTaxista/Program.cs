using System;

namespace GeometriaDelTaxista
{
    class Program
    {
        static void Main(string[] args)
        {
            DistanceService service = new DistanceService();
            Point p1 = new Point(1, 4);
            Point p2 = new Point(5, 8);
            Console.WriteLine(service.Calculate(p1, p2));
            
        }
    }
}
