using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Invoice
    {
        //Если использовать константу, то тогда даже через конструктор нельзя будет инициализировать переменные
        //Если использовать readonly, то можна будет один раз инициализировать переменные в конструкторе
        //Я использую одно поле как константу,  а к остальным применил readonly
        const int account = 1;
        readonly string customer = "Intel";
        readonly string provider = "LifeCell";

        public Invoice()
        {
            customer = "AMD";

            provider = "Vodafone";
        }

        int quantity;
        string article;

        
        //---можно реализовать двумя методами (один с НДС, другой без НДС)
        public double GetSumWithVAT(int quantity, string article)
        {
            return quantity * 175.00;
        }

        public double GetSumWithoutVAT(int quantity, string article)
        {
            return quantity * 175.00 - (quantity * 175.00 / 6);
        }

        //---можно через один (но тогда нужно добавить еще один параметр для обозначения какую суму мы хотим получить с НДС или без НДС)

        public double GetSum(int quantity, string article, int flag)
        {
            double sum;
            if (flag == 0)
            {
                sum = quantity * 175;
            }
            else 
            {
                sum = quantity * 175.00 - (quantity * 175.00 / 6);
            }

            return sum;
        }

        //---можно через один (но тогда нужно добавить еще один исходящий параметр, для вывода суммы без НДС)

        public double GetSum(int quantity, string article, out double sumWithoutVAT)
        {         
            sumWithoutVAT = quantity * 175.00 - (quantity * 175.00 / 6);
           
            return quantity * 175;
        }

    }
}
