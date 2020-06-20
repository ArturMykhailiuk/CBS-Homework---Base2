using System;
using System.Runtime.CompilerServices;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Михайлюк", "Артур");

            Console.Write("Спецiалiст: ");
            Console.Write(employee.Lastname);
            Console.Write(" ");
            Console.WriteLine(employee.Firstname);
            
            employee.SetPosition("Розробник баз даних");               
            Console.WriteLine("Посада:  {0}", employee.Position);    

            Console.Write("Заробiтна плата: ");
            Console.WriteLine(employee.GetSalary("Розробник баз даних", 3, out double tax));

            Console.Write("Податковий збiр: ");
            Console.WriteLine(tax);
            
        }
    }
}
