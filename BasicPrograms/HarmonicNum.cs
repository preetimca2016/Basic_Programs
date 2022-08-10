using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class HarmonicNum
    {
        public void HarmonicFun()
        {
            Console.WriteLine("enter the number");
            int N = Convert.ToInt32(Console.ReadLine());
            while(N<=0)
            {
                Console.WriteLine("invalid input, Enter the number : ");
                 N = Convert.ToInt32(Console.ReadLine());
            }
            float Result_Harmonic = 0;
            for (float i=1; i<=N;i++)
            {
                Result_Harmonic += 1/i;
            }
            Console.WriteLine("the Harmonic Result is "+Result_Harmonic);
        }
    }
}
