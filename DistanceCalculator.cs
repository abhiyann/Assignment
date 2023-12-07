using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public struct Point2D
    {
        public float x;
        public float y;
    }
    public class DistanceCalculator
    {
        public static float CalculateDistance(Point2D point1, Point2D point2)
        {
            float xDiff = point2.x - point1.x;
            float yDiff = point2.y - point1.y;

            return (float)Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
        }
    }
}
