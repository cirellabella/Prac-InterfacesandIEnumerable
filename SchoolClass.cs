using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_InterfacesandIEnumerable
{
    public class SchoolClass : IEnumerable
    {
        //fields
        public string _className;
        public List<Student> _classRoster;

        public SchoolClass()
        {
            _className = "prog124";
            _classRoster = new List<Student>();

            _classRoster.Add(new Student("Cirella"));
            _classRoster.Add(new Student("Kasey"));
            _classRoster.Add(new Student("John"));
            _classRoster.Add(new Student("Pam"));
            _classRoster.Add(new Student("Kim"));
            _classRoster.Add(new Student("Karly"));
            _classRoster.Add(new Student("Christine"));
            _classRoster.Add(new Student("Cain"));
            _classRoster.Add(new Student("Caius"));
            _classRoster.Add(new Student("Cody"));
            _classRoster.Add(new Student("Kyli"));
            _classRoster.Add(new Student("Karlie"));
            _classRoster.Add(new Student("Jason"));
            _classRoster.Add(new Student("Cary"));
            _classRoster.Add(new Student("Angelica"));
            _classRoster.Add(new Student("Kelly"));
            _classRoster.Add(new Student("Alexis"));
            _classRoster.Add(new Student("Katrice"));
            _classRoster.Add(new Student("Illiana"));
            _classRoster.Add(new Student("Payton"));

        }

        public IEnumerator GetEnumerator()
        {
            SchoolClassEnumerator sce = new SchoolClassEnumerator(_classRoster);
            return sce;
        }

        public class SchoolClassEnumerator : IEnumerator
        {
            // Fields we need
            // THe current index
            // The list we are working with
            int index = -1;
            List<Student> _classRoster;

            public SchoolClassEnumerator(List<Student> classRoster)
            {
                _classRoster = classRoster;
            }

            public object Current => _classRoster[index];

            public bool MoveNext()
            {
                // We increment the index
                index++;

                // then we check to see if it's past the last item in the list
                if (index >= _classRoster.Count)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public void Reset()
            {
                index = -1;
            }


        }


    }
}
