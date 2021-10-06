using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler_Game
{
    class Gamblers_Solution
    {
        /// <summary>
        /// method to start beating
        /// </summary>
        public void start()
        {
            //variable declaration
            int money = 100; //total money
            int bet = 1; //bet 1 every day
            int win = 0;
            int loss = 0;
            Console.WriteLine("Total money :" +money);
            
            //cheating random variable
            Random random = new Random();
            
            int toss = random.Next(0, 2);
            
            //condition to check person winning or loss
            if (toss == 0)
            {
                win += bet;
                Console.WriteLine($"Total money after winnig is :{money + win} ");
            }
            else if (toss == 1)
            {
                loss -= bet;
                Console.WriteLine($"Total money after winnig is :{money + loss} ");
            }

        }
    }
}
