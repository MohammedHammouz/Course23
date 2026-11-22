using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Meeting_Times_for_a_Calendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<DateTime> meetingTimes = new SortedSet<DateTime>()
            {
                new DateTime(2026,10,22,17,0,0),
                new DateTime(2026,10,22,22,0,0),
                new DateTime(2026,10,22,20,0,0)
            };
            foreach(var meet in meetingTimes)
            {
                Console.WriteLine(meet.Hour);
            }
        }
    }
}
