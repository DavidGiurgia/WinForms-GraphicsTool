using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Bussiness
{
    public class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point2D()
        {}
        public Point2D(int x, int y)
        {
            this.X = x; 
            this.Y = y;
        }
        public Point2D(Point point)
        {
            this.X = point.X;
            this.Y = point.Y;
        }
        public Point2D(Point2D p)
        {
            this.X = p.X;
            this.Y = p.Y;
        }
        public override string ToString()
        {
            return $"{X}, {Y}";
        }
        public Point ToPoint()
        {
            return new Point(X, Y);
        }
    }
}
