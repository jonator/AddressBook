using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
        public string FirstName;
        public string LastName;
        public PhoneNumber PhoneNumber;
        public string Email;

        public Contact(string firstName, string lastName, PhoneNumber phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
