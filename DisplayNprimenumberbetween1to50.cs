using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class DisplayNprimenumberbetween1to50
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    Console.WriteLine(j);


                }
            }
        }
    }
}

