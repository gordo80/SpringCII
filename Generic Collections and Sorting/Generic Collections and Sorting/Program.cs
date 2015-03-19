using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_and_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Person> personList = new List<Person>();
            Person person1 = new Person("Cregg","Claudia Jean",291);
            Person person2 = new Person("Lyman", "Joshua", 507);
            Person person3 = new Person("Ziegler", "Toby", 362);
            Person person4 = new Person("Bartlet", "Josiah", 123);
            Person person5 = new Person("Seaborn", "Sam", 118);
           
            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);
            personList.Add(person4);
            personList.Add(person5);
            
            //Display method with no sorting
            Display("message",personList);
            //Call first name Comparer
            
            Person.ByFirstNameComparer fn = new Person.ByFirstNameComparer();
            personList.Sort(fn);
            //Display firstName by sorting
            Display("message",personList);

            Person.ByLastNameComparer fl = new Person.ByLastNameComparer();
            personList.Sort(fl);
            //Display sort by last name
            Display("message",personList);

            Person.ByIdComparer IDC = new Person.ByIdComparer();
            personList.Sort(IDC);
            Display("message",personList);

            ////two null objects into the personList
            Person person6 = new Person();
            Person person7 = new Person();
            personList.Add(person6);
            personList.Add(person7);
            Person.ByLastNameComparer lastnull = new Person.ByLastNameComparer();
           // personList.Sort(lastnull);

            


            Display("test",personList);
        }

        private static void Display(string message,List<Person> list)
        {
            foreach (Person s in list)
            {
                Console.WriteLine(message+" "+s);
            }
        }
    }
}
