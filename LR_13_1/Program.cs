namespace LR_13_1
{
    internal class Program
    {

        static void f(double x1, double y1, double x2, double y2)
        {
            double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(result);
        }

        static void t(double a, double b, double c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine($"Треугольник со сторонами а = {a}, b = {b}, c = {c} - Существует!");
            } else
            {
                Console.WriteLine($"Треугольник со сторонами а = {a}, b = {b}, c = {c} - Не существует!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление длины отрезка по заданным координатам:");
            f(1, 3, 2, 5);

            Console.WriteLine("Проверка существования треугольника по заданным сторонам:");
            t(2, 3, 4);
        }
    }
}
