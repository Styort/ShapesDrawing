using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDrawing.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Shape
    {
        public Circle(int size, Color color, Point center) : base(size, color, center)
        {
            Name = "Круг";
        }

        public override double CalculateArea()
        {
            double radius = Size / 2;
            double pi = Math.PI;
            return pi * (radius * radius);
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color, 3);

            var circle = new Rectangle(Center.X - Size / 2, Center.Y - Size / 2, Size, Size);

            graphics.DrawEllipse(pen, circle);
            graphics.FillEllipse(new SolidBrush(Color), circle.X, circle.Y, circle.Width, circle.Height);
        }

        public override bool IsHit(int x, int y)
        {
            int dx = Center.X - x;
            int dy = Center.Y - y;
            return dx * dx + dy * dy <= Size / 2 * Size / 2;
        }
    }
}
