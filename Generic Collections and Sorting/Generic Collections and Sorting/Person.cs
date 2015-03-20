using System;
using System.Collections;
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
        //
        public static readonly ByFirstNameComparer first;
        public static readonly ByLastNameComparer last;
        public static readonly ByIdComparer idc;
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
        //FirstNameClass
        public class ByFirstNameComparer:IComparer<Person>
        {

            public int Compare(Person x, Person y)
            {
               return string.Compare(x.firstName,y.firstName);
            }
        }
        //LastNameClass
        public class ByLastNameComparer : IComparer<Person>
        {

            public int Compare(Person x, Person y)
            {
                return string.Compare(x.lastName,y.lastName);
                
            }
        }
        //ID Class
        public class ByIdComparer : IComparer<Person>
        {

            public int Compare(Person x, Person y)
            {
                if (x.id > y.id)
                {
                    return 1;
                }
                else if (x.id < y.id)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
