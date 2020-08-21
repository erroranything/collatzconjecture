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
            try //testing if is int
            {
                ulong.Parse(number); 
            }
            catch(Exception)
            {
                Console.WriteLine("not an integer");
                isInt = false;
            }
            bool looping = true; //starting the thing.
            ulong IntNumber = ulong.Parse(number); //convert string to ulong (unsigned 64 bit)
            if(isInt)
            {
                while(looping)
                {
                    Console.WriteLine(IntNumber);
                    if (IntNumber == 1) //detects if is in an endless loop
                    {
                        Console.WriteLine("infinite loop, stopping program");
                        Thread.Sleep(5000);
                        looping = false; //stops program
                    }
                    else
                    {
                        if (IntNumber % 2 == 0) //detects if is even or odd
                        {
                            IntNumber /= 2; //does calculations for even
                        }
                        else //does calcualations for odd
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
