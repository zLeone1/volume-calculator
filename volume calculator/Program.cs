using System;
using volume_calculator;



class Program
{
    static void Main(string[] args)
    {
        VolumeCalculator calculator = new VolumeCalculator();
        calculator.PrintInfo();

        Console.WriteLine("what do you want o calculazte \n 1. Cube \n 2. Cylinder");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                int cubeVolumeInt = (int)calculator.CalculateVolume(5);
                
                calculator.PrintVolume(cubeVolumeInt);

                double cubeVolumeDouble = calculator.CalculateVolume(5.5);
                calculator.PrintVolume(cubeVolumeDouble);
                break;



            case 2:
              

                int cylinderVolumeInt = (int)calculator.CalculateVolume(4, 6);
                
                calculator.PrintVolume(cylinderVolumeInt);

                double cylinderVolumeDouble = calculator.CalculateVolume(4.5, 6.5);
                calculator.PrintVolume(cylinderVolumeDouble);

                break;
        }


       

        
    }
}

