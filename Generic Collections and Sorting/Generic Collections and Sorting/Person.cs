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
        //ByFirstNameComparer first;
        //ByLastNameComparer last;
        //ByIdComparer idc;

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
                if (x == null)
                {
                    if (y == null)
                    {
                        // If x is null and y is null, they're 
                        // equal.  
                        return 0;
                    }
                    else
                    {
                        // If x is null and y is not null, y 
                        // is greater.  
                        return -1;
                    }
                }
                else
                {
                    if (y == null)
                    {
                        return 1;
                    }
                    else
                    {
                        int ret = x.firstName.CompareTo(y.firstName);
                        if (ret != 0)
                        {
                            return ret;
                        }
                        else
                        {
                            return x.firstName.CompareTo(y.firstName);
                        }
                    }
                }
            }
        }
        //LastNameClass
        public class ByLastNameComparer : IComparer<Person>
        {

            public int Compare(Person x, Person y)
            {
                if (x == null)
                {
                    if (y == null)
                    {
                        // If x is null and y is null, they're 
                        // equal.  
                        return 0;
                    }
                    else
                    {
                        // If x is null and y is not null, y 
                        // is greater.  
                        return -1;
                    }
                }
                else
                {
                    if (y == null)
                    {
                        return 1;
                    }
                    else
                    {
                        int ret = x.lastName.CompareTo(y.lastName);
                        if (ret != 0)
                        {
                            return ret;
                        }
                        else
                        {
                            return x.lastName.CompareTo(y.lastName);
                        }
                    }
                }
            }
        }
        //ID Class
        public class ByIdComparer : IComparer<Person>
        {

            public int Compare(Person x, Person y)
            {
                if (x == null)
                {
                    if (y == null)
                    {
                        // If x is null and y is null, they're 
                        // equal.  
                        return 0;
                    }
                    else
                    {
                        // If x is null and y is not null, y 
                        // is greater.  
                        return -1;
                    }
                }
                else
                {
                    if (y == null)
                    {
                        return 1;
                    }
                    else
                    {
                        int ret = x.id.CompareTo(y.id);
                        if (ret != 0)
                        {
                            return ret;
                        }
                        else
                        {
                            return x.id.CompareTo(y.id);
                        }
                    }
                }
            }
        }
    }
}
