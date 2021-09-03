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
            Type type1 = p1.GetType();
            Type type2 = p2.GetType();

            var output = (int)type1.InvokeMember("GetPoint1",
                                    BindingFlags.Instance | BindingFlags.InvokeMethod |
                                    BindingFlags.NonPublic, null, p1);
            var result = type1.FindMembers(MemberTypes.Method,BindingFlags.NonPublic, new MemberFilter(DelegateToSearchCriteria), null);
            type1.

            return Math.Abs(p1.GetPoint1() - p1.GetPoint2()) + Math.Abs(p1.GetPoint1() - p1.GetPoint2());
        }
        public static bool DelegateToSearchCriteria(MemberInfo objMemberInfo, Point objSearch)
        {
            // Compare the name of the member function with the filter criteria.
            if (objMemberInfo.Name.ToString() == objSearch.ToString())
                return true;
            else
                return false;
        }
    }
}
