using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ShapesDrawing.Shapes;

namespace ShapesDrawing
{
    /// <summary>
    /// Класс работы с данными. Сериализация/десериализация XML.
    /// </summary>
    public class DataManager
    {
        // путь к папке с приложением
        private static string dataFolder = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));

        // путь к файлу с данными
        private static string shapesFilepath;

        public DataManager()
        {
            shapesFilepath = Path.Combine(dataFolder, "shapes.json");
        }
        
        /// <summary>
        /// Загрузка данных из файла
        /// </summary>
        public List<Shape> LoadShapes()
        {
            try
            {
                // если файла с данными нет, то не загружаем
                if (!File.Exists(shapesFilepath)) return new List<Shape>();

                // десериализуем список фигур из файла
                return JsonConvert.DeserializeObject<List<Shape>>(File.ReadAllText(shapesFilepath), new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    NullValueHandling = NullValueHandling.Ignore,
                });
            }
            catch (Exception e)
            {
                return new List<Shape>();
            }
        }


        /// <summary>
        /// Сохранение данных в файле
        /// </summary>
        public void SaveShapes(List<Shape> shapes)
        {
            try
            {
                // сериализуем обьет и сохраняем в файл
                JsonSerializer serializer = new JsonSerializer();
                serializer.Converters.Add(new Newtonsoft.Json.Converters.JavaScriptDateTimeConverter());
                serializer.NullValueHandling = NullValueHandling.Ignore;
                serializer.TypeNameHandling = TypeNameHandling.Auto;
                serializer.Formatting = Formatting.Indented;

                using (StreamWriter sw = new StreamWriter(shapesFilepath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, shapes, typeof(List<Shape>));
                }
            }
            catch (Exception e)
            {
                // игнорируем ошибки
            }
        }
    }
}
