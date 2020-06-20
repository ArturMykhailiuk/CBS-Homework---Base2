using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Converter
    {      
        double usduah { get; set; }
        double euruah { get; set; }
        double rubuah { get; set; }
        double uahusd { get; set; }
        double uaheur { get; set; }
        double uahrub { get; set; }
        
        public double USDUAH { get { return usduah; } }
        public double EURUAH { get { return euruah; } }
        public double RUBUAH { get { return rubuah; } }
        public double UAHUSD { get { return uahusd; } }
        public double UAHEUR { get { return uaheur; } }
        public double UAHRUB { get { return uahrub; } }
        
        public Converter(double usd, double eur, double rub)
        {
            usduah = 26.7 * usd;
            euruah = 29.2 * eur;
            rubuah = 0.40 * rub;
        }

        public Converter(double uah)
        {
            uahusd = uah / 26.7;
            uaheur = uah / 29.2;
            uahrub = uah / 0.40;
        }
    }
}
