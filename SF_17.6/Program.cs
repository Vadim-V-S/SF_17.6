using System;

namespace SF_17._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(InputAcccountType(), InputAcccountBalance());

            Calculator calculator = new Calculator();
            Console.WriteLine("Сумма по проценту банка: " + calculator.CalculateInterest(account));


            Console.ReadKey();
        }


        static string InputAcccountType()
        {
            Console.Write("Введите тип счета:\t");
            return Console.ReadLine().ToLower();
        }


        static double InputAcccountBalance()
        {
            Console.Write("Введите баланс:\t");
            return double.Parse(Console.ReadLine());
        }
    }
}
