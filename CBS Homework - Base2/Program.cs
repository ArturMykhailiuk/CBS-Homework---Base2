using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter curTOuah = new Converter(5, 10, 100);
          
            Console.WriteLine("Доллар к гривне - {0}", curTOuah.USDUAH);
            Console.WriteLine("Евро к гривне - {0}", curTOuah.EURUAH);
            Console.WriteLine("Рубль к гривне - {0}", curTOuah.RUBUAH);

            Converter uahTOcur = new Converter(1000);
            Console.WriteLine("\nГривня к доллару - {0}", uahTOcur.UAHUSD);
            Console.WriteLine("Гривня к евро - {0}", uahTOcur.UAHEUR);
            Console.WriteLine("Гривня к рубллю - {0}", uahTOcur.UAHRUB);
        }
    }
}
