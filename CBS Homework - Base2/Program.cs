using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(100,100,100);
          
            Console.WriteLine("Доллар к гривне - {0}", converter.UsdToUah());
            Console.WriteLine("Евро к гривне - {0}", converter.EurToUah());
            Console.WriteLine("Рубль к гривне - {0}", converter.RubToUah());

            Converter converterToUah = new Converter(1000);
            Console.WriteLine("\nГривня к доллару - {0}", converterToUah.UahToUsd());
            Console.WriteLine("Гривня к евро - {0}", converterToUah.UahToEur());
            Console.WriteLine("Гривня к рубллю - {0}", converterToUah.UahToRub());
        }
    }
}
