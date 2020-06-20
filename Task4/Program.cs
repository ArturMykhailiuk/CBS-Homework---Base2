using System;
using System.Diagnostics.Contracts;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();

            //---использование двух методов
            Console.WriteLine("Сумма с НДС: {0}", invoice.GetSumWithVAT(10, "CPU Intel"));
            Console.WriteLine("Сумма без НДС: {0}", invoice.GetSumWithoutVAT(10, "CPU Intel"));

            //---использование еще одного входящего параметра
            Console.WriteLine("\nСумма с НДС: {0}", invoice.GetSum(10, "CPU Intel", 0));
            Console.WriteLine("Сумма без НДС: {0}", invoice.GetSum(10, "CPU Intel", 1));

            //---использование еще одного исходящего параметра
            Console.WriteLine("\nСумма с НДС: {0} ", invoice.GetSum(10, "CPU Intel", out double sumWithoutVAT));
            Console.WriteLine("Сумма без НДС: {0} ", sumWithoutVAT);

        }
    }
}
