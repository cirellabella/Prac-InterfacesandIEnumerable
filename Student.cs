using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_InterfacesandIEnumerable
{
    public class Student
    {
        //field
        string _firstName;

        //constructor
        public Student(string firstName)
        {
            this._firstName = firstName;
        }

        //properties
        public string FirstName { get => _firstName; set => _firstName = value; }

        public override string ToString()
        {
            return $"Student Name: {FirstName}";
        }



    }
}
