using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment.Exercises
{
    public class Exercise_5
    {

        //Type of Duck – Use enum to represent this value
        enum DuckType { Rubber = 0, Mallard = 1, Redhead = 2 };


        public interface IShowDetail
        {
            void ShowDetails();
        }
        class Duck : IShowDetail
        {
            private double weight;
            private int numberWings;
            private DuckType duckType;
            /// <summary>
            /// Constructor
            /// </summary>
            public Duck() { }
            /// <summary>
            /// Constructor with arguments
            /// </summary>
            /// <param name="weight"></param>
            /// <param name="numberWings"></param>
            /// <param name="duckType"></param>
            public Duck(double weight, int numberWings, DuckType duckType)
            {
                this.weight = weight;
                this.numberWings = numberWings;
                this.duckType = duckType;
            }
            /// <summary>
            /// Show details
            /// </summary>
            public virtual void ShowDetails()
            {
                if (duckType == DuckType.Mallard)
                {
                    Console.WriteLine("Mallard duck:");
                }
                if (duckType == DuckType.Rubber)
                {
                    Console.WriteLine("Rubber duck:");
                }
                if (duckType == DuckType.Redhead)
                {
                    Console.WriteLine("Redhead duck:");
                }
                Console.WriteLine("Weight: {0}", weight);
                Console.WriteLine("Number of wings: {0}", numberWings);
            }
        }
        class RubberDuck : Duck
        {
            public RubberDuck(double weight, int numberWings, DuckType duckType)
                : base(weight, numberWings, duckType)
            {


            }
            public override void ShowDetails()
            {
                base.ShowDetails();
                Console.WriteLine("Rubber ducks don’t fly and squeak.");
            }
        }
        class MallardDuck : Duck
        {
            public MallardDuck(double weight, int numberWings, DuckType duckType)
                : base(weight, numberWings, duckType)
            {


            }
            public override void ShowDetails()
            {
                base.ShowDetails();
                Console.WriteLine("Mallard ducks fly fast and quack loud.");
            }
        }
        class RedheadDuck : Duck
        {
            public RedheadDuck(double weight, int numberWings, DuckType duckType)
                : base(weight, numberWings, duckType)
            {


            }
            public override void ShowDetails()
            {
                base.ShowDetails();
                Console.WriteLine("Redhead ducks fly slow and quack mild.");
            }
        }


        public void Execute()
        {
            //Create ducks
            IShowDetail[] ducks = new IShowDetail[3];
            ducks[0] = new RubberDuck(12, 2, DuckType.Rubber);
            ducks[1] = new MallardDuck(9, 2, DuckType.Mallard);
            ducks[2] = new RedheadDuck(15, 4, DuckType.Redhead);


            //Show details of a duck, i.e. when you call for e.g. ShowDetails() method of a duck, duck should print its traits.
            for (int i = 0; i < 3; i++)
            {
                ducks[i].ShowDetails();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
