using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Basics
{
    internal class Human
    {
        //member variable
        //private string firstName;
        public string firstName;
        public string lastName;
        public int age;

        // constructor
        // default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // parameterized constructor
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        //member 
        public void IntroduceMyself()
        {   if(age != 0 && lastName != null && firstName != null)
                Console.WriteLine("Hi, I'm {0} {1}, my age is {2}", firstName, lastName, age);
            else if(lastName != null && firstName != null)
                Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
            else if(firstName != null)
                Console.WriteLine("Hi, I'm {0}", firstName);
            else
                Console.WriteLine("Hi");
                
        }
    }
}
