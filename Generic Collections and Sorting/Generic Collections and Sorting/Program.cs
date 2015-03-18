using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_and_Sorting
{
    class Program
    {
        //Person.ByFirstNameComparer first = new Person.ByFirstNameComparer();
        //Person.ByLastNameComparer last = new Person.ByLastNameComparer();
        //Person.ByIdComparer idc = new Person.ByIdComparer();
        
        //Person.ByIdComparer idc;
        static void Main(string[] args)
        {
            
            List<Person> personList = new List<Person>();
            Person person1 = new Person("Cregg","Claudia Jean",291);
            Person person2 = new Person("Lyman", "Joshua", 507);
            
            
            personList.Add(p);
            //Display(personList);
        }

        //private static void Display(List<Person> list)
        //{
        //    Console.WriteLine();
        //    foreach (Person s in list)
        //    {
        //        Console.WriteLine(s);
        //    }
        //}
    }
}
