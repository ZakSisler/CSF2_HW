using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        private string _customerId;
        private string _firstName;
        private string _lastName;
        public ContactInfo _contactInfo;

        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public ContactInfo ContactInfo
        {
            get { return _contactInfo; }
            set { _contactInfo = value; }
        }

        public Customer(string customerId, string firstName, string lastName, ContactInfo contactInfo)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            ContactInfo = contactInfo;
        }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("Customer ID: {0} " +
                "\nFirst Name: {1}" +
                "\nLast Name: {2}" +
                "\nContact Info: {3}",
                CustomerId, FirstName, LastName, ContactInfo);
        }
    }
}
