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
    /// Треугольник
    /// </summary>
    public class Triangle : Shape
    {
        public Triangle(int size, Color color, Point center) : base(size, color, center)
        {
            Name = "Треугольник";
        }

        public override double CalculateArea()
        {
            return Size * Size / 2;
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color, 3);

            Point[] pnt = new Point[3];

            pnt[0].X = (int)(Center.X);
            pnt[0].Y = (int)(Center.Y - Size / 2);
            
            pnt[1].X = (int)(Center.X + Size / 2);
            pnt[1].Y = (int)(Center.Y + Size / 2);

            pnt[2].X = (int)(Center.X - Size / 2);
            pnt[2].Y = (int)(Center.Y + Size / 2);

            graphics.DrawPolygon(pen, pnt);

            // заполняем треугольник
            Brush brush = new SolidBrush(Color);

            //Now relocate the points for the triangle.
            pnt[0].X = Center.X;
            pnt[1].X = Center.X + Size / 2;
            pnt[2].X = Center.X - Size / 2;

            graphics.FillPolygon(brush, pnt);
        }

        public override bool IsHit(int x, int y)
        {
            float d1, d2, d3;
            bool has_neg, has_pos;

            // координаты нажатия
            Point pt = new Point(x,y);

            // координаты верхнего угла треугольника
            Point v1 = new Point(Center.X, Center.Y - Size / 2);
            // координаты правого угла треугольника
            Point v2 = new Point(Center.X + Size / 2, Center.Y + Size / 2);
            // координаты правого левого треугольника
            Point v3 = new Point(Center.X - Size / 2, Center.Y + Size / 2);
            
            d1 = sign(pt, v1, v2);
            d2 = sign(pt, v2, v3);
            d3 = sign(pt, v3, v1);

            has_neg = (d1 < 0) || (d2 < 0) || (d3 < 0);
            has_pos = (d1 > 0) || (d2 > 0) || (d3 > 0);

            return !(has_neg && has_pos);
        }

        float sign(Point p1, Point p2, Point p3)
        {
            return (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
        }
    }
}
