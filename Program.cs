using System;

namespace Task_7_Фабрика_Фигур
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Выберите фигуру 1-квадрат 2-круг 3-треугольник");

            //квадрат
            Square aquare = new Square();
            aquare.display();
            aquare.perimeter();
            aquare.area();
            aquare.colorRandom();
            aquare.getInfo();

            //круг
            Сircle circle = new Сircle();
            circle.display();
            circle.perimeter();
            circle.area();
            circle.colorRandom();
            circle.getInfo();

            //треугольник
            Triangle triangle = new Triangle();
            triangle.display();
            triangle.perimeter();
            triangle.area();
            triangle.colorRandom();
            triangle.getInfo();
        }
    }
}
