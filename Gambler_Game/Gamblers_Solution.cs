using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler_Game
{
    class Gamblers_Solution
    {
        //variable declaration
        int money = 100; //total money
        int bet = 1; //bet 1 every day

        /// <summary>
        /// method to start beating
        /// </summary>
        public void start()
        {
            int win = 0;
            int loss = 0;
            Console.WriteLine("Total money :" +money);
            
            //cheating random variable
            Random random = new Random();
            int win1 = 100;
            int loss1 = 100;

            //condition to check person winning or loss
            while (win1 ==150 ||loss1 ==50)
            {
                int toss = random.Next(0, 2);
                if (toss == 0)
                {
                    win += bet;
                    win1++;
                    Console.WriteLine($"Total money after winnig is : " +win1);
                }
                else if (toss == 1)
                {
                    loss -= bet;
                    loss1--;
                    Console.WriteLine($"Total money after lossing is : " +loss1);
                }
               // Console.WriteLine("Remaing money" + money);
            }
            
        }
    }
}
