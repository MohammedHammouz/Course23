using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
namespace Dynamic_List_of_Students_in_a_Classroom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> students = new ObservableCollection<string>();
            students.CollectionChanged += (sender, e) =>
            {
                //this event will be fired on any change (add or remove.

                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"New Student Added: {e.NewItems[0]}");
                if (e.Action == NotifyCollectionChangedAction.Remove)
                    Console.WriteLine($"Student Removed: {e.OldItems[0]}");
            };
            students.Add("Alice");
            students.Add("Bob");
            students.Remove("Alice");
            Console.ReadKey();
        }
       
    }
}
