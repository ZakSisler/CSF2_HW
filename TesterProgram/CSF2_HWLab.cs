using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class CSF2_HWLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCSF2 HW LAB!\n\n");

            Student s1 = new Student();
            s1.FirstName = "Frodo";
            s1.LastName = "Baggins";
            s1.Id = "h0bb1t";
            s1.Gpa = 3.2f;

            Console.WriteLine(s1);

            Vehicle v1 = new Vehicle();
            v1.Make = "Toyota";
            v1.Model = "Tundra";
            v1.Year = 2009;
            v1.Weight = 5000f;

            Console.WriteLine(v1);

            Login l1 = new Login();
            l1.UserName = "zman";
            l1.Password = "zdawgR00lz";

            Console.WriteLine(l1);

            ContactInfo c1 = new ContactInfo();
            c1.StreetAddress = "1234 Dingleberry Lane";
            c1.City = "Dingleton";
            c1.State = "Missouri";
            c1.Zip = "65556";
            c1.Phone = "808-867-5309";
            c1.Email = "dingleberry@dingle.com";

            Console.WriteLine(c1);

            //CUSTOMER
            //Customer cus1 = new Customer();//casting, boxing, unboxing?!?!?! 
            //cus1.CustomerId = "123hfh";
            //cus1.FirstName = "Captain";
            //cus1.LastName = "Ahab";
            //cus1.ContactInfo = "????? mobius h. dick";
            //            ||   ???
            //Customer cus1 = new Customer("123hfh", "Captain", "Ahab", "????? mobius h. dick");

            //Console.WriteLine(cus1);

        }
    }
}
