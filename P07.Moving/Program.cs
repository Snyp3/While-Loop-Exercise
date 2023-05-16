using System;

namespace P07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freePlace = lenght * width * height;
            string input;
            int freePlaceNeedet = 0;
            while (freePlace > 0)
            {
                input = Console.ReadLine();
                if(input == "Done")
                {
                    Console.WriteLine($"{freePlace} Cubic meters left.");
                    break;
                }
                freePlace -= int.Parse(input);
                if(freePlace < 0)
                {
                    freePlaceNeedet = Math.Abs(freePlace - 0);
                    Console.WriteLine($"No more free space! You need {freePlaceNeedet} Cubic meters more.");

                }


            }
        }
    }
}
