using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsListLinq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var contact = new Contact();
            var contactsList = new ContactsList();
            var selectedContacts = contactsList.CList.Where(w => w.FirstName.ToUpper().StartsWith("A"));
            Console.WriteLine(@"First name starts with ""A""" + Environment.NewLine);
            foreach (var item in selectedContacts)
            {
                item.Display();
            }

            var orderedByContacts = contactsList.CList.OrderBy(o => o.LastName);
            Console.WriteLine("\nOrdered by last name");
            foreach (var item in orderedByContacts)
            {
                item.Display();
            }

            var firstOrDefaultContact = contactsList.CList.FirstOrDefault(name => name.LastName.Length > 4);
            Console.WriteLine("\nFirst item with last name with more than four chars:");
            int counter = 0;
            for (int i = 0; i < firstOrDefaultContact.LastName.Length; i++)
            {
                while (counter <= 0)
                {
                    firstOrDefaultContact.Display();
                    counter++;
                }
            }

            var withSelectedContacts = contactsList.CList.Take(3);
            Console.WriteLine("\nThree items were taken: ");
            foreach (var item in withSelectedContacts)
            {
                item.Display();
            }

            var skipedContactsList = contactsList.CList.Skip(2);
            Console.WriteLine("\nSkiped first and second items:");
            foreach (var item in skipedContactsList)
            {
                item.Display();
            }
        }
    }
}
