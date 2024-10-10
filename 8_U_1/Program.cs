using System.Text;
//Напишіть 4 перевантаження методу Method, який виводить
//деякі значення на екран. Викличте всі 4 навантаження
//методу Method у методі Main. 

namespace _8_U_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Method();
            Console.WriteLine();
            Method(35);
            Console.WriteLine();
            Method(23, 5);
            Console.WriteLine();
            Method(10,45,24);
            Console.ReadLine();
            
        }

        static void Method()
        {
            Console.WriteLine("Hello, World!");
        }

        static void Method(int l)
        {
            Console.WriteLine($"Довжина відрізка {l}!");
        }

        static void Method(int a, int b) { 
            Console.WriteLine($"Площа прямокутника {a*b}!");
        }

        static void Method(int a, int b, int c)
        {
            double s, p;
            p = a + b + c;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Площа трикутника {s}!");
        }
    }
}
