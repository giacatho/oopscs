using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kahoot.DynamicBinding1
{
    public class Test
    {
        static void Main()
        {
            new Person().printPerson();
            new Student().printPerson();
        }
    }
    
    class Person
    {
        public virtual string getInfo()
        {
            return "Person";
        }

        public void printPerson()
        {
            Console.WriteLine(getInfo());
        }
    }

    class Student : Person
    {
        public override string getInfo()
        {
            return "Student";
        }
    }
}
