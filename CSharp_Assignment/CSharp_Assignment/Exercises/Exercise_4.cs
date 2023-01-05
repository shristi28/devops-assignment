using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment.Exercises
{
    public class Equipment
    {
        public string Name;                       //all the data members of the parent class

        public string Description;
        public int DMTD;
        public int MaintainceCost;
        public enum TOE { Mobile = 1, Immobile = 2 };     //enum variable to store the type
        public virtual void MoveBy(int DistanceMoved, int Wheels)       //moveby function made virtual for overriding it later
        {
            DMTD = DMTD + DistanceMoved;
            MaintainceCost = Wheels * DistanceMoved;


        }


    }
    public class Mobile : Equipment
    {
        public override void MoveBy(int DistanceMoved, int Wheels)    //overridden
        {
            DMTD = DMTD + DistanceMoved;
            MaintainceCost = Wheels * DistanceMoved;

        }
    }
    public class Immobile : Equipment
    {
        public override void MoveBy(int DistanceMoved, int Weight)
        {
            DMTD = DMTD + DistanceMoved;
            MaintainceCost = Weight * DistanceMoved;

        }
    }

    class EXERCISE_4
    {
        public void Execute()
        {
            Console.WriteLine("enter 1 if you want to make mobile equipment");
            Console.WriteLine("enter 2 if u want to make immobile equipment");
            string ans = Console.ReadLine();

            if (ans == Convert.ToString(Equipment.TOE.Immobile))
            {
                Immobile obj1 = new Immobile();
                Console.WriteLine("enter name");
                obj1.Name = Console.ReadLine();
                Console.WriteLine("enter description");
                obj1.Description = Console.ReadLine();
                obj1.DMTD = 0;
                obj1.MaintainceCost = 0;
                Console.WriteLine("Enter Distance ");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Weight");
                int w = Convert.ToInt32(Console.ReadLine());
                obj1.MoveBy(d, w);
                Console.WriteLine(obj1.Name);
                Console.WriteLine(obj1.Description);
                Console.WriteLine(obj1.DMTD);
                Console.WriteLine(obj1.MaintainceCost);



            }
            else
            {
                Mobile obj2 = new Mobile();

                Console.WriteLine("enter name");
                obj2.Name = Console.ReadLine();
                Console.WriteLine("enter description");
                obj2.Description = Console.ReadLine();
                obj2.DMTD = 0;
                obj2.MaintainceCost = 0;
                Console.WriteLine("Enter Distance ");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number of wheels");
                int w = Convert.ToInt32(Console.ReadLine());
                obj2.MoveBy(d, w);
                Console.WriteLine(obj2.Name);
                Console.WriteLine(obj2.Description);
                Console.WriteLine(obj2.DMTD);
                Console.WriteLine(obj2.MaintainceCost);
            }
        }
    }
}
