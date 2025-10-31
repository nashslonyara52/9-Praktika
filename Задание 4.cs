using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            if (!double.TryParse(Console.ReadLine(), out double radius) || radius <= 0)
            {
                Console.WriteLine("Ошибка. Радиус должен быть больше 0");
                return;
            }
            Circle circle = new Circle(radius);
            circle.GetArea();
        }
    }
    class Circle
    {
        private double radius;
        public Circle(double r) 
        {
            radius = r; 
        }
        public void GetArea()
        {
            double area = radius * radius * Math.PI;
            Console.WriteLine($"Площадь круга: {area:F2}");
        }
        public double Radius
        {
            set { radius = value; }
            get { return radius; }
        }
    }
}