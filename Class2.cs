using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp001
{
    public struct st1 
    { 
        public int a1;
        public int a2;
        public int a3;
        public int a4;
    }

    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}",FirstName, LastName, Age);
        }
    }
}
