using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment.Exercises
{
    class Exercise_15
    {
		public void Execute()
		{
			ObservableCollection<string> names = new ObservableCollection<string>();
			names.CollectionChanged += names_CollectionChanged;
			names.Add("Adya");
			names.Add("Samira");
			names.Remove("Adya");
			names.Add("Joein");
			names.Add("Paridhi");
			names.Remove("Samira");
		}

		static void names_CollectionChanged(object sender, NotifyCollectionChangedEventArgs x)
		{
			Console.WriteLine("\nChange type: " + x.Action);
			if (x.NewItems != null)
			{
				Console.WriteLine("\nItems added: ");
				foreach (var item in x.NewItems)
				{
					Console.WriteLine(item);
				}
			}

			if (x.OldItems != null)
			{
				Console.WriteLine("\nItems removed: ");
				foreach (var item in x.OldItems)
				{
					Console.WriteLine(item);
				}
			}
		}
	}
}
