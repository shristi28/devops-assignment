using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment
{
    class Exercise_7
    {
        interface IDuckType //Interface
        {
            void Show();
        }
        class Ducks : IDuckType  //base class inheriting interface
        {
            float Weight;
            int NumberOfWings;
            public void GetInfo() //Getting UserInput
            {
                Console.WriteLine("Enter Weight of the Duck");
                this.Weight = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Number of Wings");
                this.NumberOfWings = int.Parse(Console.ReadLine());
            }
            public virtual void Show() // virtual function for overriding
            {
                Console.WriteLine("The weight of the duck is {0}", this.Weight);
                Console.WriteLine("Number of Wings of this Duck are {0}", this.NumberOfWings);
            }
            public float GetWeight()
            {
                return this.Weight;
            }
            public int GetWings()
            {
                return this.NumberOfWings;
            }
        }
        class ReadHeadDuck : Ducks //Derived class ReadHead Duck
        {
            public ReadHeadDuck()
            {
                Console.WriteLine("A ReadHeaded Duck is Created");
            }
            public override void Show()
            {
                Console.WriteLine("This is a ReadHeaded Duck");
                base.Show();
                Console.WriteLine("ReadHead Ducks fly slow and Quack mild");
            }
        }
        class MallardDuck : Ducks //Derived Class Mallard duck
        {
            public MallardDuck()
            {
                Console.WriteLine("A Mallard Duck is Created");
            }
            public override void Show() //Overriding base class function
            {
                Console.WriteLine("This is a Mallard Duck");
                base.Show();
                Console.WriteLine("Mallard Ducks fly fast and Quack loud");
            }
        }
        class RubberDuck : Ducks  //Derived class
        {
            public RubberDuck()
            {
                Console.WriteLine("A Rubber Duck is Created");
            }
            public override void Show() //Overriding base class function
            {
                Console.WriteLine("This is a Rubber Duck");
                base.Show();
                Console.WriteLine("Rubber Ducks don't fly and Squeak");
            }
        }
        public enum DuckTypes //enum class
        {
            ReadHead = 1,
            Mallard,
            Rubberhead
        }

        public void Execute()
        {
            Console.WriteLine("WELCOME TO DUCK SIMULATION GAME\n\n");
            List<Ducks> DuckList = new List<Ducks>();
            int Choice = 0;

            while (Choice != 6)
            {
                Console.WriteLine("Select the Action you want to perform\n");
                Console.WriteLine("1: Add a Duck\n");
                Console.WriteLine("2: Remove a Duck\n");
                Console.WriteLine("3: Remove all Ducks\n");
                Console.WriteLine("4: Display Ducks in Icreasing order of their weight\n");
                Console.WriteLine("5: Display Ducks in Increasing number of wings\n");
                Console.WriteLine("6: Exit\n");
                if (!int.TryParse(Console.ReadLine(), out Choice))
                {
                    Console.WriteLine("Please Select Valid Option\n");
                }
                else
                {
                    switch (Choice)
                    {
                        case 1:
                            AddDuck(DuckList);
                            break;
                        case 2:
                            RemoveDuck(DuckList);
                            break;
                        case 3:
                            DuckList.Clear();
                            Console.WriteLine("All Ducks are Removed\n");
                            break;
                        case 4:
                            DisplayAll(DuckList);
                            break;
                        case 5:
                            IteratebyWings(DuckList);
                            break;
                        case 6: break;
                        default:
                            Console.WriteLine("Error!!! Please Select a valid option ");
                            break;

                    }


                }

            }

        }

        static void AddDuck(List<Ducks> DuckList)
        {
        start:
            Console.WriteLine("Enter the Duck you want to create 1(ReadHead) or 2(Mallard) or 3(Rubber)");


            if (int.TryParse(Console.ReadLine(), out int Option))
            {
                if (Option == Convert.ToInt32(DuckTypes.ReadHead))
                {
                    var Object1 = new ReadHeadDuck();  //creating a readhead duck object
                    Object1.GetInfo();
                    DuckList.Add(Object1);

                }
                else if (Option == Convert.ToInt32(DuckTypes.Mallard))
                {
                    var Object2 = new MallardDuck();  //creating a Mallard duck object
                    Object2.GetInfo();
                    DuckList.Add(Object2);

                }
                if (Option == Convert.ToInt32(DuckTypes.Rubberhead))
                {
                    var Object3 = new RubberDuck();  //creating a Rubber duck object
                    Object3.GetInfo();
                    DuckList.Add(Object3);
                }


            }
            else
            {
                Console.WriteLine("Please enter Valid Input(1,2 or 3)");
                goto start;//jump to start
            }

        }
        static void RemoveDuck(List<Ducks> DuckList)
        {
            if (DuckList.Count > 0)
            {
                DisplayAll(DuckList);
                int SelectDuck;
                Console.Write("Select the Duck you want to delete: ");
                if (!int.TryParse(Console.ReadLine(), out SelectDuck) || SelectDuck < 0 || SelectDuck > DuckList.Count)
                {
                    Console.WriteLine("\nSelect a Valid Duck.");
                }
                else
                {
                    Console.WriteLine("\nThe Duck deleted is");
                    DuckList[SelectDuck - 1].Show();
                    DuckList.RemoveAt(SelectDuck - 1);

                }


            }
            else
            {
                Console.WriteLine("\nThere are no Ducks in the list");
            }
        }
        static void DisplayAll(List<Ducks> DuckList)
        {
            if (DuckList.Count > 1)
            {
                DuckList.Sort(delegate (Ducks x, Ducks y)
                {
                    return x.GetWeight().CompareTo(y.GetWeight());

                });


                foreach (Ducks dq in DuckList)
                {
                    dq.Show();
                    Console.WriteLine("\n\n");
                }
            }
            else { Console.WriteLine("There are no ducks in the list"); }
        }
        static void IteratebyWings(List<Ducks> DuckList)
        {
            if (DuckList.Count > 1)
            {
                DuckList.Sort(delegate (Ducks x, Ducks y)
                {
                    return x.GetWings().CompareTo(y.GetWings());

                });
                DisplayAll(DuckList);

            }
        }

    }
}

