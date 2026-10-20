using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Time_Leaderboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string , int> Players = new SortedList<string, int> { { "Ahmad", 150 },{ "Mohammed", 200 }, { "Ali", 100 } };
            foreach (var player in Players)
            {
                Console.WriteLine($"Name:{player.Key},Score={player.Value}");
            }
        }
    }
}
