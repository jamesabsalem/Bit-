using System;

namespace Bit__
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStatement = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            for (int i = 0; i < numberOfStatement; i++)
            {
                var statement = Console.ReadLine().Replace("X", "");
                if (statement == "++")
                {
                    x++;
                }
                else
                {
                    x--;
                }
                

            }
            Console.WriteLine(x);
        }
    }
}
