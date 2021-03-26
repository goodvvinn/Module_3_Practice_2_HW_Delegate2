using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsListLinq
{
    public class ContactsList
    {
        public ContactsList()
        {
            CList = new List<Contact>()
            {
                new Contact("Alex", "Goodvvinn", 37, "+38066-361-87-93"),
                new Contact("Bob", "Marley", 100, "+0123-456-789"),
                new Contact("John", "Doe", 150, "+987-765-54"),
                new Contact("Alice", "Cooper", 70, "+6987-345-23"),
                new Contact("Bill", "Jones", 50, "+345-44-22"),
            };
        }

        public List<Contact> CList { get; set; }
    }
}
