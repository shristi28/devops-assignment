using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment.Exercises
{
    public class Exercise_2
    {
        public void Execute()
        {
            //1st Case
            string name = "kartik";
            string myName = name;

            //Get True output for both the == Operator and the Equals() method.
            Console.WriteLine("== operator result is {0}", name == myName);
            Console.WriteLine("Equals method result is {0}", name.Equals(myName));

            // 2nd Case
            object name2 = "kartik";
            char[] values = { 'k', 'a', 'r', 't', 'i', 'k' };
            object myName2 = new string(values);

            /* == Operator returns False because it compares the reference identity
            while the Equals() method returns True because it compares the contents of the objects.*/
            Console.WriteLine("\n== operator result is {0}", name2 == myName2);
            Console.WriteLine("Equals method result is {0}", myName2.Equals(name2));

            // 3rd
            object o1 = null;
            object o2 = new object();

            //Technically, these should read object.ReferenceEquals for clarity, but this is redundant.

            Console.WriteLine("\n" + ReferenceEquals(o1, o1)); //true
            Console.WriteLine(ReferenceEquals(o1, o2)); //false
            Console.WriteLine(ReferenceEquals(o2, o2)); //true

            // o1.Equals(o1); NullReferenceException
            // o1.Equals(o2); NullReferenceException
            Console.WriteLine("\n" + o2.Equals(o1)); //false
            Console.WriteLine(o2.Equals(o2)); //true

            Console.ReadKey();
        }
    }
}