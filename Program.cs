using System;

namespace Task_7_Фабрика_Фигур
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; ; i++)
            {
                Console.WriteLine("Выберите фигуру 1-квадрат, 2-круг, 3-треугольник, 0-выйти из программы");
                int figure = int.Parse(Console.ReadLine()); //выбор фигуры

                switch (figure)
                {


                    case 1: //квадрат
                        Console.WriteLine("Вы выбрали квадра: ");
                        Square aquare = new Square();
                        aquare.display();
                        aquare.perimeter();
                        aquare.area();
                        aquare.colorRandom();
                        aquare.getInfo();
                        break;

                    case 2: //круг
                        Console.WriteLine("Вы выбрали круг: ");
                        Сircle circle = new Сircle();
                        circle.display();
                        circle.perimeter();
                        circle.area();
                        circle.colorRandom();
                        circle.getInfo();
                        break;

                    case 3: //треугольник
                        Console.WriteLine("Вы выбрали треугольник: ");
                        Triangle triangle = new Triangle();
                        triangle.display();
                        triangle.perimeter();
                        triangle.area();
                        triangle.colorRandom();
                        triangle.getInfo();
                        break;

                    case 0:
                        Console.WriteLine("Вы вышли из программы!");
                        break;

                    default:
                        Console.WriteLine("Не верно введи номер фигуры");
                        break;
                }

            }
            
        }
    }
}
