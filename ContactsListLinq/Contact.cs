using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsListLinq
{
    public class Contact
    {
        public Contact()
        {
        }

        public Contact(string firstName, string lastName, int age, string phoneNum)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            PhoneNum = phoneNum;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNum { get; set; }
        public void Display()
        {
            Console.WriteLine($"|First name: {FirstName}, |Last name: {LastName}, |age: {Age}, |phone number: {PhoneNum}");
        }
    }
}
