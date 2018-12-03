using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethPatt
{


    public class Point
    {
        //Factory Method
        public static Point PointWithCartes(double x, double y)
        {
            return new Point(x, y);
        }

        private double x, y;
        public Point()
        {
        }

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }


    }

    class Program
    {




        static void Main(string[] args)
        {
        }
    }
}
