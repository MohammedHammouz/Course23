using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
namespace Dynamic_Weather_Updates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> weatherUpdates = new ObservableCollection<string>();
            weatherUpdates.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"Weather Update: {e.NewItems[0]}");
            };
            weatherUpdates.Add("New York: Sunny, 25°C");
            weatherUpdates.Add("London: Rainy, 15°C");
            // Output:
            // Weather Update: New York: Sunny, 25°C
            // Weather Update: London: Rainy, 15°C
            Console.ReadKey();
        }
    }
}
