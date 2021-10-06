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
            int win = 100;
            int loss = 100;
            Console.WriteLine("Total money :" +money);
            
            //cheating random variable
            Random random = new Random();
            

            //condition to check person winning or loss
            while (win != 150 || loss != 50)
            {
               
                    int toss = random.Next(0, 2);
                    if (toss == 0)
                    {
                        win += bet;
                       
                        Console.WriteLine($"Total money after winnig is : " + win);
                    }
                    else if (toss == 1)
                    {
                        loss -= bet;
                        
                        Console.WriteLine($"Total money after lossing is : " + loss);
                    }
                    // Console.WriteLine("Remaing money" + money);

               
            }
        }
    }
}
