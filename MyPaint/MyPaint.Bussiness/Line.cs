using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;

namespace MyPaint.Bussiness
{
    public class Line : Shape
    {
        private Point2D Ending {  get; set; }
        public override void Initialize(Point2D origin, Point2D ending)
        {
            this.Origin = new Point2D(origin);
            this.Ending = new Point2D(ending);

            this.PenWidth = 2;
                
            this.NameKey = $"(Line: {Origin.ToString()} -> {Ending.ToString()})";
        }
        public override void Draw(Graphics g)
        {
            if (Origin != null && Ending != null)
            {
                Pen pen = new Pen(Color.Black, PenWidth);

                g.DrawLine(pen, Origin.X, Origin.Y, Ending.X, Ending.Y);

                pen.Dispose();
            }
        }
        public override void MoveTo(Point2D newLocation)
        {
            Ending = new Point2D(Ending.X - (Origin.X - newLocation.X), Ending.Y - (Origin.Y - newLocation.Y));
            Origin = newLocation;
        }
    }
}
