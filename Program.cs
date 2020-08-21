using System;

namespace hailstone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give number");
            string number;
            while (true)
            {
                bool isInt = true;
                number = Console.ReadLine();
                try
                {
                    ulong.Parse(number);
                }
                catch (Exception)
                {
                    Console.WriteLine("not an integer");
                    isInt = false;
                }
                bool looping = true;
                ulong IntNumber = ulong.Parse(number);
                if (isInt)
                {
                    while (looping)
                    {
                        Console.WriteLine(IntNumber);
                        if (IntNumber == 1)
                        {
                            Console.WriteLine("infinite loop. gimme again");
                            looping = false;
                        }
                        else
                        {
                            if (IntNumber % 2 == 0)
                            {
                                IntNumber /= 2;
                            }
                            else
                            {
                                IntNumber *= 3;
                                IntNumber += 1;
                            }
                        }
                    }
                }
            }
        }
    }
}
