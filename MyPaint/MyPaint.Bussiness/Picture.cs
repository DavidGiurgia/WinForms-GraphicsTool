using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Bussiness
{
    class Picture : Shape
    {
        private List<Shape> _shapes;

        public Picture()
        {
            _shapes = new List<Shape>();
        }

        public override void Draw(Graphics g)
        {
            foreach (var item in _shapes)
            {
                item.Draw(g);
            }
        }

        public override void MoveTo(Point2D point2D)
        {
            throw new NotImplementedException();
        }

        public override void Add(Shape shape)
        {
            _shapes.Add(shape);
        }

        public override void Remove(Shape shape)
        {
            _shapes.Remove(shape);
        }
    }
}
