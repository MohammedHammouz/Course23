using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
namespace Task_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> tasks = new ObservableCollection<string>();
            tasks.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"Task Added: {e.NewItems[0]}");
                if (e.Action == NotifyCollectionChangedAction.Remove)
                    Console.WriteLine($"Task Removed: {e.OldItems[0]}");
            };

            tasks.Add("Complete report");
            tasks.Add("Attend meeting");
            tasks.Remove("Complete report");
            // Output:
            // Task Added: Complete report
            // Task Added: Attend meeting
            // Task Removed: Complete report
            Console.ReadKey();
        }
    }
}
