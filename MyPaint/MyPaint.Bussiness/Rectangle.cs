using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Bussiness
{
    public class Rectangle : Shape
    {
        int width {  get; set; }
        int height { get; set; }
        public override void Initialize(Point2D origin, Point2D ending)
        {
            int startX = Math.Min(origin.X, ending.X);
            int startY = Math.Min(origin.Y, ending.Y);
            int endX = Math.Max(origin.X, ending.X);
            int endY = Math.Max(origin.Y, ending.Y);

            width = endX - startX;
            height = endY - startY;

            PenWidth = 2;

            this.Origin = new Point2D(startX, startY);
            this.NameKey = $"(Rectangle: {Origin.ToString()} -> {new Point2D(endX, endY)})" ;
        }
        public override void Draw(Graphics g)
        {
            if (Origin != null)
            {
                Pen pen = new Pen(Color.Black, PenWidth);

                g.DrawRectangle(pen, Origin.X, Origin.Y, width, height);

                pen.Dispose();
            }
        }

        public override void MoveTo(Point2D point2D)
        {
            Origin = new Point2D(point2D.X - width / 2, point2D.Y - height / 2);
        }

    }
}
