﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment.Exercises
{
    public class InvalidNumberException : Exception
    {
        public InvalidNumberException(string message)


      : base(message) { }
    }


    public class Exercise_17
    {
        public void Execute()
        {


            int userNumber = -1;
            int nTimesPlayed = 0;
            while (nTimesPlayed < 5)
            {
                try
                {
                    Console.Write("Enter any number from 1-5: ");
                    string answer = Console.ReadLine();
                    if (!isCorrectAnswer(answer, 1, 5, 0, false))
                    {
                        userNumber = -1;
                    }
                    else
                    {
                        int.TryParse(answer, out userNumber);
                        nTimesPlayed++;
                        if (userNumber == 1)
                        {
                            getUserAnswer("Enter even number: ", userNumber);
                        }
                        else if (userNumber == 2)
                        {
                            getUserAnswer("Enter odd number: ", userNumber);


                        }
                        else if (userNumber == 3)
                        {
                            getUserAnswer("Enter a prime number: ", userNumber);


                        }
                        else if (userNumber == 4)
                        {
                            getUserAnswer("Enter a negative number: ", userNumber);


                        }
                        else if (userNumber == 5)
                        {
                            getUserAnswer("Enter a zero number: ", userNumber);
                        }
                    }


                }
                catch (InvalidNumberException ep)
                {
                    Console.WriteLine(ep.Message);
                    userNumber = -1;
                }
            }
            Console.WriteLine("\nYou have played this game for 5 times.\n");


            Console.ReadLine();
        }

        static void getUserAnswer(string message, int selectedMethod)
        {
            const int minNumber = int.MinValue;
            const int maxNumber = int.MaxValue;
            Console.Write(message);
            string inputString = Console.ReadLine();
            if (isCorrectAnswer(inputString, minNumber, maxNumber, 0, false))
            {
                if (isCorrectAnswer(inputString, minNumber, maxNumber, selectedMethod, true))
                {
                    Console.WriteLine("It is a correct answer.");
                }
            }
        }



        static bool isCorrectAnswer(string message, int minNumber, int maxNumber, int selectedMethod, bool hasNextFunctions)
        {


            if (!hasNextFunctions)
            {
                int num = -1;
                if (!int.TryParse(message, out num))
                {
                    throw new InvalidNumberException(string.Format("Enter any integer number from {0}-{1}.", minNumber, maxNumber));
                }
                else
                {
                    if (num < minNumber || num > maxNumber)
                    {
                        throw new InvalidNumberException(string.Format("Enter any number from {0}-{1}.", minNumber, maxNumber));
                    }
                    return true;
                }
            }
            else
            {
                int num = -1;
                int.TryParse(message, out num);
                if (selectedMethod == 1)
                {
                    if (num % 2 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        throw new InvalidNumberException("\nIt is not even number.\n");
                    }


                }
                if (selectedMethod == 2)
                {
                    if (num % 2 == 1)
                    {
                        return true;
                    }
                    else
                    {
                        throw new InvalidNumberException("\nIt is not odd number.\n");
                    }


                }
                if (selectedMethod == 3)
                {
                    if (numberIsPrime(num))
                    {
                        return true;
                    }
                    else
                    {
                        throw new InvalidNumberException("\nIt is not a prime number.\n");
                    }


                }
                if (selectedMethod == 4)
                {
                    if (num < 0)
                    {
                        return true;
                    }
                    else
                    {
                        throw new InvalidNumberException("\nIt is not a negative number.\n");
                    }


                }
                if (selectedMethod == 5)
                {
                    if (num == 0)
                    {
                        return true;
                    }
                    else
                    {
                        throw new InvalidNumberException("\nIt is not a zero number.\n");
                    }


                }
                return false;
            }
        }


        static bool numberIsPrime(int x)
        {
            if (x == 1) return false;
            if (x == 2) return true;


            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(x)); i++)
                if (x % i == 0)
                    return false;
            return true;
        }
    }
}
