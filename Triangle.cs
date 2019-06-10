using System;
using System.Collections.Generic;
using System.Text;

namespace Task_7_Фабрика_Фигур
{
      public class Triangle
    {
        double [] side = new double [3]; // стороны треугольника
        double perimeterP; // периметр треугольника
        double areaS; // площадь треугольника
        string colorRan; // цвет
        public void display()
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine($"Введите {i+1}-ю сторону: ");
                side[i] = double.Parse(Console.ReadLine()); // полученная сторона
            }
        }

        public void perimeter() //периметр треугольника
        {
            perimeterP = side[0] + side[1] + side[2];
        }
        public void area()    // площадь треугольника
        {
            double PoluPerimeter = (side[0]+ side[1] + side[2]) / 2; // полумериметр треушольника
            double value = PoluPerimeter * (PoluPerimeter - side[0]) * (PoluPerimeter - side[1]) * (PoluPerimeter - side[2]);
            areaS = Math.Sqrt(value);
        }
        public void colorRandom() //рандомный цвет треугольника
        {
            string[] color = { "чёрный", "белый", "зелёный", "синий", "красный", "жёлтый", "оранжевый", "глубой", "серый", "коричневый" }; //цвет
            Random ran = new Random();
            int nums = (ran.Next(0, 9));
            colorRan = Convert.ToString(color[nums]);
        }
        public void getInfo()
        {
            Console.WriteLine($" Параметры треугольника: \n Периметр: {perimeterP}\n Площадь: {areaS}\n Цвет: {colorRan}");
        }
    }
}
