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

        }
    }
}
