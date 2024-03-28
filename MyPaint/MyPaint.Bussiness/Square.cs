using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Bussiness
{
    public class Square : Shape
    {
        public int length{  get; set; }

        public override void Initialize(Point2D origin, Point2D ending)
        { 
            PenWidth = 2;
            if(length == 0 )
            {
                length = 100;
            }
            Origin = new Point2D(origin.X - (length / 2), origin.Y - (length / 2));
            NameKey = $"(Square {Origin}  length:{this.length})";
        }

        public override void Draw(Graphics g)
        {
            if (Origin != null)
            {
                NameKey = $"(Square {Origin}  length:{this.length})";
                Pen pen = new Pen(Color.Black, PenWidth);

                g.DrawRectangle(pen, Origin.X, Origin.Y, length, length);

                pen.Dispose();
            }
        }

        public override void MoveTo(Point2D point2D)
        {
            this.Origin.X = point2D.X - (length / 2);
            this.Origin.Y = point2D.Y - (length / 2);
        }

    }
}
