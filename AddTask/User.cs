using System;
using System.Collections.Generic;
using System.Text;

namespace AddTask
{
    class User
    {         
        public string Login     { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public int Age          { get; set; }
        public DateTime Date1   { get; set; }

        public User()   
        {
            Login = "Droop";
            FirstName = "Artur";
            LastName = "Mykhailiuk";
            Age = 39;
            Date1 = DateTime.Now;            
        }
    }
}
