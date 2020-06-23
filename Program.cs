using System;

namespace Classi4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какую фигуру создаём?");
            Console.WriteLine("1 - квадрат \n 2 - круг");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Введите координаты");
                Console.Write("x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("y: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Write("a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Square fig = new Square(x, y, a, b);
                Console.WriteLine("x точки: ");
                int xp = Convert.ToInt32(Console.ReadLine());
                Console.Write("y точки: ");
                int yp = Convert.ToInt32(Console.ReadLine());
                bool qwe;
                qwe = fig.PointIN(xp, yp);
                if (qwe == true)
                {
                    Console.WriteLine("Точка в квадрате");

                }
                else
                {
                    Console.WriteLine("Точка HE в квадрате");
                }

            }
            else
            {

                Console.WriteLine("Введите координаты");
                Console.Write("x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("y: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Write("r: ");
                int r = Convert.ToInt32(Console.ReadLine());
                Circle fig = new Circle(x, y, r);
                Console.WriteLine("x точки: ");
                int xp = Convert.ToInt32(Console.ReadLine());
                Console.Write("y точки: ");
                int yp = Convert.ToInt32(Console.ReadLine());
                bool qwe;
                qwe = fig.PointIN(xp, yp);
                if (qwe == true)
                {
                    Console.WriteLine("Точка в окружности");

                }
                else
                {
                    Console.WriteLine("Точка HE в окружности");
                }
            }
            
            
        }
    }
}
