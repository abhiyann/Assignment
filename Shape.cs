using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Shape
    {
        public virtual float CalculateArea()
        {
            return 0;
        }
    }

    public class Circle : Shape
    {
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public override float CalculateArea()
        {
            return (float)(Math.PI * radius * radius);
        }
    }
}
