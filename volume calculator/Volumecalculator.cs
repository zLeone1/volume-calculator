using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volume_calculator
{
    public class VolumeCalculator
    {
        public double CalculateVolume(int sideLength)
        {
            return Math.Pow(sideLength, 3);
        }

        public double CalculateVolume(double sideLength)
        {
            return Math.Pow(sideLength, 3);
        }

        public double CalculateVolume(int radius, int height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        public double CalculateVolume(double radius, double height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
        public void PrintInfo()
        {
            Console.WriteLine("This Program calculates the Volume of Cubes and Cylinders");
            Console.WriteLine("Please, enter the information required to calculate the volumes");
        }
        public void PrintVolume(double volume)
        {
            Console.WriteLine($"The calculated volume is (double): {volume}");
        }
        public void PrintVolume(int volume)
        {
            Console.WriteLine($"The calculated volume is (int):{volume}");
        }

    }
}
