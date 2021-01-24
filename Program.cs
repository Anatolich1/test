using System;

namespace gitest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Beep(1500, 3000);
            Console.Beep(1500, 3000);

            Console.Beep(1500, 3000); Console.Beep(1500, 3000);

            Console.Beep(1500, 3000);
        }
    }
}
