using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_6_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[25];
            Random rnd = new Random();
            int min;
            int max;

            min = Convert.ToInt32(Console.ReadLine());
            max = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < numbers.Length; i++)
            { 

                numbers[i] = rnd.Next(min, max);
                Console.WriteLine(numbers[i]);

            }


            Console.WriteLine("Press ENTER to Close....");




                Console.ReadLine();
        }
    }
}
