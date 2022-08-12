using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class FlipCoinPercentage
    {
        int Head = 0;
        int Tail = 0;
        public void FlipCoin()
        {
            Console.WriteLine("Enter the number of time you want to flip the coin:- ");
            int NumberOfFlips = Convert.ToInt32(Console.ReadLine());

            while (NumberOfFlips <= 0)
            {
                Console.WriteLine("Invalid Input, Enter the number of time you want to flip the coin:- ");
                NumberOfFlips = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < NumberOfFlips; i++)
            {
                Random flip = new Random();
                int HoT = flip.Next(0, 2);

                if (HoT < 0.5)
                {
                    Head++;
                }
                else
                {
                    Tail++;
                }
                float Head_Percentage = (float)Head * 100 / NumberOfFlips;
                float Tail_Percentage = (float)Tail * 100 / NumberOfFlips;
                Console.WriteLine("Percentage of Head are :" + Head_Percentage);
                Console.WriteLine("Percentage of Tail are :" + Tail_Percentage);
            }
        }
    }
}
