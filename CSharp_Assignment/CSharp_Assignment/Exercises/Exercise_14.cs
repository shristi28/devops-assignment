using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment.Exercises
{
    public class Exercise_14
    {
        public void Execute()
        {
            Exercise_14 exercise_14 = new Exercise_14();
        }


        public class PriceChangedEventArgs : EventArgs
        {
            public float Difference { get; private set; }
            public PriceChangedEventArgs(float difference)
            {
                Difference = difference;
            }
        }


        public class Product
        {
            public event EventHandler ChangeDefectiveness;
            public event EventHandler<PriceChangedEventArgs> ChangePrice;

            int id;
            float price;
            bool isDefective;

            public int GetId()
            {
                return id;
            }

            public float GetPrice()
            {
                return price;
            }

            public void SetPrice(float rate)
            {
                PriceChangedEventArgs x = new PriceChangedEventArgs(rate - price);
                price = rate;
                ChangePrice(this, x);
            }

            public bool GetIsDefective()
            {
                return isDefective;
            }

            public void SetIsDefective(bool value)
            {
                isDefective = value;
                ChangeDefectiveness(this, null);
            }

            public Product(int id, float price, bool isDefective)
            {
                this.id = id;
                this.price = price;
                this.isDefective = isDefective;
            }

            public override bool Equals(Object obj)
            {
                if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                    return false;
                else
                {
                    Product pt = (Product)obj;
                    return (this.id == pt.GetId()) && (this.price == pt.GetPrice())
                        && (this.isDefective == pt.GetIsDefective());
                }
            }

            public override int GetHashCode()
            {
                return this.id;
            }

            public override string ToString()
            {
                return $"Product: {id} costs {price}";
            }
        }

        public class Inventory
        {
            public float Total { get; set; }
            public Dictionary<Product, int> Products { get; set; }

            public Inventory()
            {
                Total = 0;
                Products = new Dictionary<Product, int>();
            }

            public void AddProduct(Product pt)
            {
                if (!pt.GetIsDefective())
                {
                    if (Products.ContainsKey(pt))
                        Products[pt] += 1;
                    else
                        Products.Add(pt, 1);
                    Total += pt.GetPrice();
                    pt.ChangeDefectiveness += new EventHandler(OnChangeDefectiveness);
                    pt.ChangePrice += new EventHandler<PriceChangedEventArgs>(OnChangePrice);
                }
            }

            public void RemoveProduct(Product pt)
            {
                if (Products.ContainsKey(pt))
                {
                    Total -= Products[pt] * pt.GetPrice();
                    Products.Remove(pt);
                }
            }

            public void UpdateProductQuantity(Product pt, int amount)
            {
                if (Products.ContainsKey(pt))
                {
                    Total += (amount - Products[pt]) * pt.GetPrice();
                    Products[pt] = amount;
                }
            }

            private void OnChangeDefectiveness(object sender, EventArgs x)
            {
                Product pt = (Product)sender;
                RemoveProduct(pt);
            }

            private void OnChangePrice(object sender, PriceChangedEventArgs x)
            {
                Product pt = (Product)sender;
                Total += Products[pt] * x.Difference;

            }

        }

    }
}




