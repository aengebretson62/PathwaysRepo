using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoster
{
    class Person
    {
        private string firstName;
        private string lastName;

        public Person()   // constructor with no parameters
        {
            firstName = "";
            lastName = "";
        }

        public Person(string newFirstName, string newLastName)  // constructor with two parameters
        {
            firstName = newFirstName;
            lastName = newLastName;
        }

        public string FirstName   // property
        {
            get { return firstName; }   // get method
            set { firstName = value; }  // set method
        }

        public string LastName   // property
        {
            get { return lastName; }   // get method
            set { lastName = value; }  // set method
        }

    }
}
