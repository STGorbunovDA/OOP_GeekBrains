using HomeWork_3.Infrastructure;
using HomeWork_3.Models;
using HomeWork_3.Models.Base;
using HomeWork_3.Repositories;
using System.Collections;
using System.Collections.ObjectModel;

namespace HomeWork_3.Presenters
{
    internal class Plane : IEnumerable
    {
        FiguraRepository figuraRepository;

        protected List<Figura> FiguresPlane { get; set; }

        public Plane()
        {
            figuraRepository = new FiguraRepository();
            FiguresPlane = new List<Figura>();
        }

        #region Заполняем фигурами Плоскость

        public void AddPlaneInFigures()
        {
            FiguresPlane = figuraRepository.GetFiguresPlane();
        }

        #endregion

        #region Печать всех фигур плоскости

        public IEnumerator GetEnumerator()
        {
            foreach (var figura in FiguresPlane)
                yield return figura;
        }

        #endregion

        #region Добавить фигуру 

        //Использование Null Object pattern
        public void CreateFigura(string name)
        {
            FiguresPlane.Add(name.ToLower() switch
            {
                "круг" => new Circle(3.0),
                "прямоугольник" => new Rectangle(2.0, 3.0),
                "квадрат" => new Square(3.0),
                "треугольник" => new Triangle(3.0, 2.0, 3.0),
                _ => new UnknownFigura()
            });
        }

        #endregion

        #region Посчитать периметр у всех фигур

        public List<string> PerimeterAllFigures()
        {
            List<string> values = new();
            foreach (var figura in FiguresPlane)
            {
                if (figura is Polygon per)
                    values.Add($"Периметр {figura}а: {per.GetPerimeter()}");
                else if (figura is Circle per2)
                    values.Add($"Периметр {figura}а: {per2.GetСircleLength()}");
            }
            return values;
        }

        #endregion

        #region Посчитать площадь у всех фигур

        public List<string> AreaAllFigures()
        {
            List<string> values = new();
            foreach (var figura in FiguresPlane)
                if (figura is IGetArea area)
                    values.Add($"Площадь: {figura}а: {area.GetArea()}");
            return values;
        }


        #endregion

        #region Посчитать длинну окружности

        public List<string> GetAllСircleLength()
        {
            List<string> values = new();
            foreach (var figura in FiguresPlane)
                if (figura is IСircleLength circleLength)
                    values.Add($"длинна окружности {figura}: {circleLength.GetСircleLength()}");
            return values;
        }


        #endregion

        #region Удалить фигуру из плоскости

        public bool RemoveFigura(int index)
        {
            if (index >= 0 && index < FiguresPlane.Count)
            {
                FiguresPlane.RemoveAt(index);
                return true;
            }
            return false;

        }

        #endregion

        #region Показать фигуру по индексу 

        public Figura this[int index]
        {
            get
            {
                try
                {
                    Figura figura = FiguresPlane.ElementAt(index);
                    return figura;
                }
                catch (Exception)
                {
                    return new UnknownFigura();
                }
            }
        }

        #endregion

        #region Изменение фигуры по индексу

        public bool ChangeFigura(int index)
        {
            if (index >= 0 && index < FiguresPlane.Count)
            {
                try
                {
                    Figura figura = FiguresPlane[index];

                    Console.WriteLine($"Вы выбрали для изменения: {figura}");

                    if (figura is Polygon figPoly)
                    {
                        if (figPoly.Name == "Треугольник")
                            figPoly.LSides = new double[] { 12.0, 13.0, 14.0 };
                        if (figPoly.Name == "Прямоугольник")
                            figPoly.LSides = new double[] { 12.0, 13.0, 12.0, 13.0 };
                        if (figPoly.Name == "Квадрат")
                            figPoly.LSides = new double[] { 12.0, 12.0, 12.0, 12.0 };
                    }
                    else if (figura is Circle circle)
                    {
                        if (circle.Name == "Круг")
                            circle.Radius = 8.0;
                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;

        }

        #endregion

        #region Сортировка по площади

        public void SortFiguresArea()
        {
            FiguresPlane = new List<Figura>(FiguresPlane.OrderBy(i => i));
        }

        #endregion

    }
}
