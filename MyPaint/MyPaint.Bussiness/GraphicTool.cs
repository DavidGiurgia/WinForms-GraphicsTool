using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace MyPaint.Bussiness
{
    public class GraphicTool
    {
        public List<Shape> Shapes { get; private set; }

        public GraphicTool()
        {
            Shapes = new List<Shape>();
        }

        public void Add(Shape shape)
        {
            Shapes.Add(shape);
        }

        public void Remove(Shape shape)
        {
            Shapes.Remove(shape);
        }

        public void DrawAll(Graphics g)
        {
            foreach (var shape in Shapes)
            {
                shape.Draw(g);
            }
        }
        public void RemoveAll()
        {
            this.Shapes.Clear();
        }
        public void SetLastShape(Shape shape)
        {
            Shapes[Shapes.Count - 1] = shape;
        }
        public override string ToString()
        {
            string nameKeys = "";
            foreach (var shape in Shapes)
            {
                nameKeys += shape.NameKey + Environment.NewLine;
            }
            return nameKeys;
        }
    }
}
