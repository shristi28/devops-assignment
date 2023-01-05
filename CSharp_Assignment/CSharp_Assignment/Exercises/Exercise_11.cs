using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment.Exercises
{ 
        public static class ExtensionMethod
        { 
            public static bool IsOdd(this int item)
            {  
            
                if (item % 2 == 0)

                {

                    return false;

                }

                return true;

            }

            public static bool IsEven(this int item)

            {

                if (item % 2 == 0)

                {

                    return true;

                }

                return false;

            }

            public static bool IsPrime(this int item)

            {

                for (int i = 2; i < item; i++)

                {

                    if (item % i == 0)

                    {

                        return false;

                    }

                }

                return true;

            }

            public static bool IsDivisbleBy(this int item, int dividor)

            {

                if (item % dividor == 0)

                {

                    return true;

                }

                return false;

            }

        }

        public class Exercise_11
        { 
            public void Execute()

            {

                bool indicator = true;

                do

                {

                    Console.WriteLine("Enter the integer");

                    int item = int.Parse(Console.ReadLine());

                    Console.WriteLine("Choose the number");

                    Console.WriteLine("1. isOdd");

                    Console.WriteLine("2. isEven");

                    Console.WriteLine("3. isPrime");

                    Console.WriteLine("4. isDivisible");

                    Console.WriteLine("5. Exit");

                    int input = int.Parse(Console.ReadLine());

                    if (input == 1)

                    {

                        bool check = item.IsOdd();

                        Console.WriteLine("Odd number - " + check);

                    }

                    else if (input == 2)

                    {

                        bool check = item.IsEven();

                        Console.WriteLine("Even number - " + check);

                    }

                    else if (input == 3)

                    {

                        bool check = item.IsPrime();

                        Console.WriteLine("Prime number - " + check);

                    }

                    else if (input == 4)

                    {

                        Console.WriteLine("Enter the dividor");

                        int val = int.Parse(Console.ReadLine());

                        if (val < 1)

                        {

                            Console.WriteLine("Enter Value greater than 0");

                        }

                        bool check = item.IsDivisbleBy(val);

                        Console.WriteLine("IsDivisble - " + check);

                    }

                    else

                    {

                        indicator = false;

                    }

                } while (indicator != false);

            }
        }
}
