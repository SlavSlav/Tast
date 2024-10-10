using System.Text;

namespace _8_U_3
{
    //Користувач вводить кількість працівників підприємства,
    //вартість 1 трудодня співробітника та кількість днів, за
    //які проводиться оплата.Створіть метод, який приймає кількість
    //співробітників, кількість робочих днів і ціну трудодня. У тілі
    //першого методу створіть метод, який рахує зарплату робітнику,
    //виходячи з кількості днів та оплати праці.Порахуйте та виведіть
    //на екран загальний обсяг грошей, необхідний для оплати зарплати
    //введеній користувачем кількості співробітників.

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;

            int quant, price, workday;
            
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            Console.WriteLine("Будь ласка, надайте кількість працівників:");
            quant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вартість 1 трудодня, будь ласка:");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("А зараз кількість днів, за які проводиться оплата:");
            workday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Groshi(price, workday);
            Groshi(quant, price, workday);
            Console.ReadLine();

        }

        static void Groshi(int price, int workday) { 
            Console.WriteLine($"Кожен працівник заробив {price*workday}!");
            Console.WriteLine();
        }

        static void Groshi(int quant, int price, int workday)
        {
            Console.WriteLine($"Загалом грошей потрібно {quant*price*workday}");
            Console.WriteLine();
        }
    }
}
