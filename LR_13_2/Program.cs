namespace LR_13_2
{
    internal class Program
    {
        static double f (double x, double a)
        {
            double y;
            if (x < a) y = 0;
            else if (x > a) y = (x - a)/(x + a);
            else y = 1;
            return y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начало отрезка a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец отрезка b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг h:");
            double h = double.Parse(Console.ReadLine());

            for (double i = a; i <= b; i += h) {
                Console.WriteLine($"x = {i}, f(x) = {f(i, a)}");
            }
        }
    }
}
