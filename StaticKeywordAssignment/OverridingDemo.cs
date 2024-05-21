using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordAssignment
{
    public class OverridingDemo
    {
      
        public virtual double CalculateArea()
        {
            return 0;
        }
    }

 
    public class Circle :   OverridingDemo
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

 
    public class Rectangle : OverridingDemo
    {
        private double length;
        private double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public override double CalculateArea()
        {
            return length * width;
        }


    }
}
