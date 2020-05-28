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
    /// Квадрат
    /// </summary>
    public class Square : Shape
    {
        // нарисованный квадрат
        private Rectangle square;

        public Square(int size, Color color, Point center) : base(size, color, center)
        {
            Name = "Квадрат";
        }

        public override double CalculateArea()
        {
            return Size * Size;
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color, 3);

            square = new Rectangle(Center.X - Size / 2, Center.Y - Size / 2, Size, Size);

            graphics.DrawRectangle(pen, square);
            graphics.FillRectangle(new SolidBrush(Color), square.X, square.Y, square.Width, square.Height);
        }

        public override bool IsHit(int x, int y)
        {
            return square.Contains(x, y);
        }
    }
}
