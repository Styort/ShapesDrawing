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
    /// Базовый класс геометрической фигуры
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Центр фигуры
        /// </summary>
        public Point Center { get; set; }

        /// <summary>
        /// Цвет фигуры
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Размер фигуры
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Название фигуры
        /// </summary>
        public string Name { get; set; }

        protected Shape(int size, Color color, Point center)
        {
            Size = size;
            Color = color;
            Center = center;
        }

        /// <summary>
        /// Расчёт площади фигуры
        /// </summary>
        public abstract double CalculateArea();

        /// <summary>
        /// Отрисовка фигуры
        /// </summary>
        public abstract void Draw(Graphics graphics);

        /// <summary>
        /// Принадлежность фигуры указанной точке
        /// </summary>
        public abstract bool IsHit(int x, int y);

        /// <summary>
        /// Выбор фигуры
        /// </summary>
        public virtual string SelectShape()
        {
            return $"Выбран {Name}, площадь = {CalculateArea()}";
        }
    }
}
