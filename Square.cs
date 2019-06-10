using System;
using System.Collections.Generic;
using System.Text;

namespace Task_7_Фабрика_Фигур
{
    public class Square
    {
        private int square;
        int side;                        //сторона
        int perimeterP;                 //периметр
        int areaS;                      //площадь
        string colorRan;
        public void display()
        {
            Console.WriteLine("Введите длину стороны: ");
            side = int.Parse(Console.ReadLine()); // полученная сторона
        }
        public void perimeter() //периметр квадрата
        {
            perimeterP = 4 * side;
        }
        public void area()    // площадь квадрата
        {
            areaS = side * side;
        }
        public void colorRandom () //ранндомный цвет квадрата
        {
            string[] color = { "чёрный", "белый", "зелёный", "синий", "красный", "жёлтый", "оранжевый", "глубой", "серый", "коричневый" }; //цвет
            Random ran = new Random();
            int nums = (ran.Next(0, 9));
            colorRan = Convert.ToString(color[nums]);
        }
          public void getInfo()
        {
            Console.WriteLine($" Параметры квадрата: \n Периметр: {perimeterP}\n Площадь: {areaS}\n Цвет: {colorRan}");
        }
    }
}
