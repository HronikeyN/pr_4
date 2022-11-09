//**********************************************************************
//*Практическая работа №4                                              *
//*Выполнил: Алексеев Н.М., группа 2ИСП                                *
//*Задание: составить программу работы линейного алгоритма             *
//**********************************************************************

using System;


namespace ПР_4
{
    class Program
    {
        static void Main(string[] args)// точка входа в программу
        {
            Console.Title = "Практическая работа № 4 "; // заголовок консоли

            double x, z, Y; //объявление переменных
            double v1, v2, v3, v4, v5, v6;

            Console.WriteLine("Здравствуйте!");
            Console.Write("Введите x = "); //ввод исходных данных
            x = Convert.ToDouble(Console.ReadLine()); // явное приведение к типу double
            Console.Write("Введите z = "); //ввод исходных данных
            z = Convert.ToDouble(Console.ReadLine()); // явное приведение к типу double 

            // расчет значения выражения 
            v1 = Math.PI / 2;
            v1 = Math.Tan(x - v1);
            v2 = Math.PI * (3 / 2);
            v2 = Math.Cos(v2 + z);
            v1 = v1 * v2;
            v3 = Math.PI * (7 / 2);
            v3 = Math.Pow(Math.Sin(v3 - x * z), 3);
            v1 -= v3;
            v4 = Math.PI * (z / 2);
            v4 = Math.Cos(x - v4);
            v5 = Math.PI * (3 / 2);
            v5 = Math.Tan(v5 + x);
            v4 = v5 / v4;

            Y = v1 / v4;

            // вывод результата на экран
            Console.WriteLine("Результат: Y = {0: #.#####}", Y);
            // или Console.WriteLine("Результат: Y = " +Y);
            Console.ReadKey(); //задержка экрана консоли

        }
    }
}
