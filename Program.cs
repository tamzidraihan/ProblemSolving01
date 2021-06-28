using System;

namespace ProblemSolving01
{
    class Program
    {
        static void Main(string[] args)
        {
            int Id = int.Parse(Console.ReadLine());
            int workedHours = int.Parse(Console.ReadLine());
            double paymentPerHour = double.Parse(Console.ReadLine());

            double salary = workedHours * paymentPerHour;

            Console.WriteLine("NUMBER = {0}\nSALARY = U$ {1:0.00}", Id, salary);
        }
    }
}
