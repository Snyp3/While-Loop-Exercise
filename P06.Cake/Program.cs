using System;

namespace P06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int pieceOfCake = lenght * width;
            string input;
            int pieces = 0;
            int piecesLeft = 0;
            ;
            while (pieceOfCake > 0)
            {
                input = Console.ReadLine();
                if (input == "STOP")
                {
                    Console.WriteLine($"{pieceOfCake} pieces are left.");
                    break;
                }
                pieceOfCake -= int.Parse(input);
                
                if (pieceOfCake <= 0)
                {
                    piecesLeft =Math.Abs(pieceOfCake - 0 );
                    Console.WriteLine($"No more cake left! You need {piecesLeft} pieces more.");
                }
            }
            
            
        }
    }
}
