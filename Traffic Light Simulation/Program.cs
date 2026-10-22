using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Traffic_Light_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BitArray trafficLights = new BitArray(3, false);
            trafficLights[0] = true;
            trafficLights[0] = false;
            trafficLights[1] = true;
            trafficLights[1] = false;
            trafficLights[2] = true;
            Console.WriteLine("Intersection 1 Lights:");
            Console.WriteLine($"Red: {trafficLights[0]}, Yellow: {trafficLights[1]}, Green: {trafficLights[2]}");
            trafficLights[2] = false;
            trafficLights[1] = true;
            Console.WriteLine($"Red: {trafficLights[0]}, Yellow: {trafficLights[2]}, Green: {trafficLights[1]}");
            Console.ReadKey();
        }
    }
}
