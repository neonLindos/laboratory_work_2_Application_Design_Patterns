using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_adp
{
    internal class task5
    {
        public class Circle
        {
            private readonly double _radius;

            public Circle(double radius)
            {
                _radius = radius;
            }

            public double CalculateArea()
            {
                return Math.PI * _radius * _radius;
            }
        }

        public class Square
        {
            private readonly double _side;

            public Square(double side)
            {
                _side = side;
            }

            public double CalculateArea()
            {
                return _side * _side;
            }
        }
    }
}
