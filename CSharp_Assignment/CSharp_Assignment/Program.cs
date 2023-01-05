using CSharp_Assignment.Exercises;
using System;

namespace CSharp_Assignment
{
    class Program
    {
        static string flag = "Y";
        static void Main(string[] args)
        {
            MenuDriven();
        }
        static void MenuDriven()
        {
            while (flag == "Y")
            {
                Console.WriteLine("\n Please enter the choice from 1 to 17 (some are not attempted) to execute the exercise: \n\n1.Exercise_1\n2.Exercise_2\n3.Exercise_3\n4.Exercise_4\n5.Exercise_5\n6.Exercise_6\n7.Exercise_7\n8.Exercise_8\n9.Exercise_9\n10.Exercise_10\n11.Exercise_11\n12.Exercise_12\n13.Exercise_13\n14.Exercise_14\n15.Exercise_15\n16.Exercise_16\n17.Exercise_17");
                string choices;
                choices = Console.ReadLine();
                switch (choices)
                {

                    case "1":
                        Exercise_1 exercises_1 = new Exercise_1();
                        exercises_1.Execute();
                        break;
                
                    
                    case "2":
                        Exercise_2 exercise_2 = new Exercise_2();
                        exercise_2.Execute();
                        break;

                    case "3":
                        Exercise_3 exercise_3 = new Exercise_3();
                        exercise_3.Execute();
                        break;

                    case "4":
                        EXERCISE_4 exercise_4 = new EXERCISE_4();
                        exercise_4.Execute();
                        break;

                    case "5":
                        Exercise_5 exercise_5 = new Exercise_5();
                        exercise_5.Execute();
                        break;

                    case "6":
                        Exercise_6 exercise_6 = new Exercise_6();
                        exercise_6.Execute();
                        break;

                    case "7":
                        Exercise_7 exercise_7 = new Exercise_7();
                        exercise_7.Execute();
                        break;

                    case "8":
                        Exercise_8 exercise_8 = new Exercise_8();
                        exercise_8.Execute();
                        break;

                    

                    case "11":
                        Exercise_11 exercise_11 = new Exercise_11();
                        exercise_11.Execute();
                        break;


                    case "12":
                        Exercise_12 exercise_12 = new Exercise_12();
                        exercise_12.Execute();
                        break;

                    case "13":
                        Exercise_13 exercise_13 = new Exercise_13();
                        exercise_13.Execute();
                        break;

                    case "14":
                        Exercise_14 exercise_14 = new Exercise_14();
                        exercise_14.Execute();
                        break;

                    case "15":
                        Exercise_15 exercise_15 = new Exercise_15();
                        exercise_15.Execute();
                        break;

                    case "16":
                        Exercise_16 exercise_16 = new Exercise_16();
                        exercise_16.Execute();
                        break;

                    case "17":
                        Exercise_17 exercise_17 = new Exercise_17();
                        exercise_17.Execute();
                        break;



                    default:
                        Console.WriteLine("Incorrect  // NOT ATTEMPTED .");
                        break;

                }
                Console.WriteLine("Please press Y to continue");
                flag = Console.ReadLine();
            }
        }
    }
}
