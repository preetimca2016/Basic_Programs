using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class Factor
    {
        public void Factors()
        {
            Console.WriteLine("Enter the number");
            int Number = Convert.ToInt32(Console.ReadLine());   
            for (
                int i = 2; i <= Number; i++)
            {
                if (Number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
