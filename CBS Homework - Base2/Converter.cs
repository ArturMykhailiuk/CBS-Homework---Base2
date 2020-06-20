using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Converter
    {      
        public double Usd { get; set; }
        public double Eur { get; set; }
        public double Rub { get; set; }
        public double Uah { get; set; }

        public Converter(double usd, double eur, double rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;
        }
        public Converter(double uah)
        {
            Uah = uah;
        }


        public double UsdToUah()
        {
            return Usd * 26.7;
        }       
        public double EurToUah()
        {
            return Eur * 29.4;
        }
        public double RubToUah()
        {
            return Rub * 0.4;
        }

        public double UahToUsd()
        {
            return Uah / 26.7;
        }
        public double UahToEur()
        {
            return Uah / 29.4;
        }
        public double UahToRub()
        {
            return Uah / 0.4;
        }

    }
}
