using System;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for(int i=0;i<25;i++)
                Console.WriteLine(rand.Next(1000,9999));
        }
    }
}
