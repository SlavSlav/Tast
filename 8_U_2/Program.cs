namespace _8_U_2
{
    //Створіть метод, у тілі якого відбувається обчислення факторіалу
    //числа рекурсивно.Пройдіть і виведіть на екран результат обчислення
    //факторіалу 5. 
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 5;
            Console.WriteLine($"Hello, World!\n {Factoria(f)}");
            Console.ReadKey();
        }

        static int Factoria(int f)
        {
            if (f > 0) return f * Factoria(f - 1);
            
            else return 1;
        }
    }
}
