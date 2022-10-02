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
        public string firstName = "";
        public string lastName = "";
        public int age;

        // constructor
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        //member 
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}, my age is {2}", firstName, lastName, age);
        }
    }
}
