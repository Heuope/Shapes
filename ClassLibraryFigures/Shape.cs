using System;

namespace ClassLibraryFigures
{
    public abstract class Shape
    {
        private double _x1;

        public double X1 { get; set; }
        public double X2 { get; set; }
        public double X3 { get; set; }

        public double Y1 { get; set; }
        public double Y2 { get; set; }
        public double Y3 { get; set; }

        public double some { get { _x1 = 1; return 1; } set { _x1 = value; } }

        public Shape(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
        }

        public Shape(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            X1 = x1;
            X2 = x2;
            X3 = x3;
            Y1 = y1;
            Y2 = y2;
            Y3 = y3;
        }
    }
}
