using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_and_Sorting
{
    class Person
    {
        private string lastName;
        private string firstName;
        private int id;

        public Person(string lastName, string firstName, int id)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.id = id;
        }
        //Default Const
        public Person()
        {
            lastName = null; firstName = null; id = 0;
        }
        //override ToString Method
        public override string ToString()
        {
            return String.Format("<{0}>: <{1}>, <{2}>", id, lastName, firstName);
        }
        //IComparer<T>
        class ByFirstNameComparer 
        {
            public interface IComparer<Person>
            {
            string CompareTo(Person obj);
            } 
        }
    }
}
