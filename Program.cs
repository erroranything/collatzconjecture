using System;
using System.Threading;

namespace hailstone
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            bool isInt = true;
            Console.WriteLine("give number");
            number = Console.ReadLine();
            try
            {
                ulong.Parse(number);
            }
            catch(Exception)
            {
                Console.WriteLine("not an integer");
                isInt = false;
            }
            bool Notlooping = true;
            ulong IntNumber = ulong.Parse(number);
            if(isInt)
            {
                while(Notlooping)
                {
                    Console.WriteLine(IntNumber);
                    if (IntNumber == 1)
                    {
                        Console.WriteLine("infinite loop, stopping program");
                        Thread.Sleep(5000);
                        Notlooping = false;
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
