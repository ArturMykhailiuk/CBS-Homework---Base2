using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }

        public Employee(string lastname, string firstname)
        {
            this.LastName = lastname;
            this.FirstName = firstname;
        }

        public void SetPosition(string position)    //---пришлось создать этот метод, так как не мог получать должность до вызова метода GetSalary()
        {
           this.Position = position;
        }
        
        public double GetSalary(string position, int expierence, out double tax)
        {
            double salary;

            if (position == "Бізнес-аналітік")
            {
                salary = 30000;
            }
            else if (position == "Адміністратор баз даних")
            {
                salary = 35000;
            }
            else if (position == "Розробник баз даних")
            {
                salary = 40000;
            }
            else
            {
                salary = 20000;
            }

            if (expierence > 1 && expierence <= 3)
            {
                salary += salary * 0.1 * expierence;
            }
            else if (expierence >= 4 && expierence <= 7)
            {
                salary += salary * 0.2 * expierence;
            }
            else
            {
                salary += salary * 0.3 * expierence;
            }

            
            tax = salary * 0.18;
            return salary;
        }
    }
}
