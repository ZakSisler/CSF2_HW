using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Students
    {
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

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
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public float Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        //FQTOR
        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Gpa = gpa;
        }

        //Default un-QTOR
        public Student() { }

        //ToString()
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("First Name: {0} " +
                "\nLast Name: {1}" +
                "\nID: {2}" +
                "\nGPA: {3:f}",
                FirstName, LastName, Id, Gpa);
                
        }

       

    }
}
