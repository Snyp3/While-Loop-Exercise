using System;

namespace P03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeedet = double.Parse(Console.ReadLine());
            double moneyAvailable = double.Parse(Console.ReadLine());
            
            
            
            string action;
            double money = 0;
            int countSpend = 0;
            int countDays = 0;

            while (moneyAvailable < moneyNeedet)
            {
                action = Console.ReadLine();
                money = double.Parse(Console .ReadLine());
                            
                if (action == "save")
                {
                    moneyAvailable += money;
                    
                    countDays++;
                    countSpend = 0;
                }
                
                else
                {
                    moneyAvailable -= money;
                    
                    if(moneyAvailable <= 0)
                        {
                            moneyAvailable = 0;
                        }                   
                    countDays++;
                    countSpend++;
                    if (action == "spend" && countSpend >=5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{countDays}");
                        break;
                    }
                   

                }
                
                if( moneyAvailable >= moneyNeedet )
                    {
                        Console.WriteLine($"You saved the money for {countDays} days.");
                        break;
                    }

                 
            }
        }
    }
}
