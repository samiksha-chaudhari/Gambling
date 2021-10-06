using System;

namespace Gambler_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int defcount = 0;//counter to break the while loop

            while (defcount == 0)
            {
                Console.WriteLine("------------------------Welcome to Gambling Problem-----------------------");
                Console.WriteLine("1.Start Beating  2.Exit");
                Console.WriteLine("Choose Option :");
                int choice = Convert.ToInt32(Console.ReadLine());//variable for taking choice from the user

                switch (choice)  //switch case
                {
                    case 1:
                        Gamblers_Solution game = new Gamblers_Solution();
                        game.start();
                        break;
                             
                    default:
                        Console.WriteLine("End");//default condition
                        defcount++;
                        break;
                }
            }
        }
    }
}
