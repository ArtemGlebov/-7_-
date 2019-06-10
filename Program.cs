using System;

namespace Task_7_Фабрика_Фигур
{
    class Program
    {
        static void Main(string[] args)
        {
            Square aquare = new Square();
            aquare.display();
            aquare.perimeter();
            aquare.area();
            aquare.colorRandom();
            aquare.getInfo();
            //Console.WriteLine("Выбирите фигуру: ");
        }
    }
}
