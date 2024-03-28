using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Bussiness
{
    public abstract class Shape
    {
        public int PenWidth { get; set; }
        public Point2D Origin { get; set; }
        public string NameKey { get; set; }
        public abstract void Draw(Graphics g);
        public abstract void MoveTo(Point2D point2D);
        public virtual void Add(Shape shape) { }
        public virtual void Remove(Shape shape) { }
        public virtual void Initialize(Point2D origin, Point2D ending) { }
    };
}
