using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
namespace Real_Time_Stock_Prices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> stockPrices = new ObservableCollection<string>();
            stockPrices.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"New Stock Price Added: {e.NewItems[0]}");
            };
            stockPrices.Add("AAPL: 150.00");
            stockPrices.Add("MSFT: 240.50");
            Console.ReadKey();
        }
    }
}
