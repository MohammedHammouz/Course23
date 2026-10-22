using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Light_Control_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            BitArray lights = new BitArray(8,false);
            lights[0] = true;
            Console.WriteLine(lights[0]);
            lights.SetAll(false);
            Console.WriteLine(lights[0]);
            Console.ReadKey();
        }
    }
}
