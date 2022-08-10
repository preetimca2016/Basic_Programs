namespace BasicPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {              
            Console.WriteLine("1: Flip coin");
            Console.WriteLine("2: Leap Year");
            Console.WriteLine("3: Power Of Two");
            Console.WriteLine("4: Harmonic Function");
            Console.WriteLine("5: Factors");
            

            int Answer = Convert.ToInt32(Console.ReadLine());
            switch(Answer)
            {            
              
                case 1:
                    FlipCoinPercentage coin = new FlipCoinPercentage();
                    coin.FlipCoin();
                    break;
                case 2:
                    LeapYears leap = new LeapYears();
                    leap.LeapYear();
                    break;
                case 3:
                    powerOfTwo power = new powerOfTwo();
                    power.PowerOfTwoNumbers();
                    break;                
                case 4:
                    HarmonicNum harmonic = new HarmonicNum();
                    harmonic.HarmonicFun();
                    break;
                case 5:
                    Factor factor = new Factor();
                    factor.Factors();
                    break;
               
            }
        }

    }
}