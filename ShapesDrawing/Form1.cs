using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapesDrawing.Shapes;

namespace ShapesDrawing
{
    public partial class Main : Form
    {
        private Random random = new Random();
        private DataManager dataManager;

        /// <summary>
        /// Список фигур
        /// </summary>
        private List<Shape> shapes = new List<Shape>();

        public Main()
        {
            InitializeComponent();
            dataManager = new DataManager();
        }

        private void CreateShapesButton_Click(object sender, EventArgs e)
        {
            var randomColor = Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
            var randomSize = random.Next(10, 100);
            var randomX = random.Next(0, canvas.Width);
            var randomY = random.Next(0, canvas.Height);

            Shape shape = null;
            var randomShape = random.Next(0, 3);
            switch (randomShape)
            {
                case 0:
                    shape = new Triangle(randomSize, randomColor, new Point(randomX, randomY));
                    break;
                case 1:
                    shape = new Circle(randomSize, randomColor, new Point(randomX, randomY));
                    break;
                case 2:
                    shape = new Square(randomSize, randomColor, new Point(randomX, randomY));
                    break;
            }

            if (shape == null) return;

            shape.Draw(canvas.CreateGraphics());

            shapes.Add(shape);
        }

        /// <summary>
        /// Обработчик нажатия на кнопку сохранения
        /// </summary>
        private void SaveShapesButton_Click(object sender, EventArgs e)
        {
            dataManager.SaveShapes(shapes);
            MessageBox.Show("Успешно сохранено!");
        }

        /// <summary>
        /// Обработчик нажатия на кнопку загрузки
        /// </summary>
        private void LoadShapesButton_Click(object sender, EventArgs e)
        {
            var graphics = canvas.CreateGraphics();

            // закрашиваем полотно
            graphics.Clear(System.Drawing.ColorTranslator.FromHtml("#F0F0F0"));

            shapes = dataManager.LoadShapes();

            // отрисовываем фигуры
            foreach (var shape in shapes)
            {
                shape.Draw(canvas.CreateGraphics());
            }
        }
        
        /// <summary>
        /// Обработчик нажатия мыши на полотно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            // проходимся в цикле по всем фигурам
            foreach (var shape in shapes)
            {
                // проверяем, входит ли фигура в нажатую область
                if (shape.IsHit(e.X, e.Y))
                {
                    MessageBox.Show(shape.SelectShape());
                }
            }
        }
    }
}
