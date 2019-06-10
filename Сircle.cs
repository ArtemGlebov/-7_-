using System;
using System.Collections.Generic;
using System.Text;

namespace Task_7_Фабрика_Фигур
{
    public class Сircle
    {
        int radius; // радиуст круга
        double perimeterP; // периметр круга
        double areaS; // площадь круга
        string colorRan;
        public void display()
        {
            Console.WriteLine("Введите радиус круга: ");
            radius = int.Parse(Console.ReadLine()); // полученный радийс
        }
        
        public void perimeter() //периметр круга
        {
            perimeterP = 2 * 3.14 * radius ;
        }
        public void area()    // площадь квадрата
        {
            areaS = 3.14*(radius* radius);
        }
        public void colorRandom() //ранндомный цвет квадрата
        {
            string[] color = { "чёрный", "белый", "зелёный", "синий", "красный", "жёлтый", "оранжевый", "глубой", "серый", "коричневый" }; //цвет
            Random ran = new Random();
            int nums = (ran.Next(0, 9));
            colorRan = Convert.ToString(color[nums]);
        }
        public void getInfo()
        {
            Console.WriteLine($" Параметры круга: \n Периметр: {perimeterP}\n Площадь: {areaS}\n Цвет: {colorRan}");
        }
    }
}
