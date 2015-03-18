using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_and_Sorting
{
    class Program
    {
        //Person.ByFirstNameComparer first;
        //Person.ByLastNameComparer last;
        //Person.ByIdComparer idc;
        static void Main(string[] args)
        {
            
            List<Person> personList = new List<Person>();
            //This is not working. I can't add a list to the Person's object.
            personList.Add("test");
        }

        private static void Display(List<string> list)
        {
            Console.WriteLine();
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
