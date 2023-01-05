using System;
using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment.Exercises
{
    class Exercise_1
    {
        public void Execute()
        {
            string val = "101";
            Console.WriteLine("Convert.Toint : (string to integer) : " + Convert.ToInt32(val));

            string input1 = "101";
            Console.WriteLine("int.Parse : (string to integer) : " + int.Parse(input1));

            int defaultout;
            string input111 = "101";
            int.TryParse(input111, out defaultout);
            Console.WriteLine("int.TryParse:(string to integer) : " + defaultout);



            string mystring = "134.4365790132273892";
            float value = float.Parse(mystring, CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine(value);


            string mystring1 = "134.4365790132273892";
            double value1 = Convert.ToDouble(mystring);
            Console.WriteLine(value1);



            int i = 1;
            bool b = Convert.ToBoolean(i);
            Console.WriteLine(b);

            string sample = "True";
            bool myBool = bool.Parse(sample);
            Console.WriteLine(myBool);



        }
    }
}
