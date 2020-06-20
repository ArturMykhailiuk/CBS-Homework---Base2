using System;
using System.Collections.Generic;
using System.Text;

namespace AddTask
{
    class User
    {

        string login; 
        string firstname;
        string lastname;
        int age;
        readonly DateTime date;
      
    
        public string Login     { get { return login; }     set { Login = value; } }
        public string FirstName { get { return firstname; } set { FirstName = value; } }
        public string LastName  { get { return lastname; }  set { LastName = value; } }
        public int Age          { get { return age; }       set { Age = value; } }
        public DateTime Date    { get { return date; } }

        public User()   
        {
            login = "Droop";
            firstname = "Artur";
            lastname = "Mykhailiuk";
            age = 39;
            DateTime date = new DateTime(2020, 6, 20);            
        }
    }
}
