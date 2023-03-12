using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoster
{
    class Instructor: Person   // The constructor with no parameters passed, lastName and firstName will be initialized with the Person constructor (base)
    {
        private string contactInfo;

        public Instructor() : base()   // The constructor with no parameters passed, lastName and firstName will be initialized with the Person constructor (base)
        {
            contactInfo = "";
        }

        public Instructor(string newFirstName, string newLastName, string newContactInfo) : base(newFirstName, newLastName)
        {
            contactInfo = newContactInfo;
        }

        public string ContactInfo   // property
        {
            get { return contactInfo; }   // get method
            set { contactInfo = value; }  // set method
        }

        public override string ToString()
        {
            return "Instructor: " + this.FirstName + " " + this.LastName + ", " + this.ContactInfo;
        }
    }
}
