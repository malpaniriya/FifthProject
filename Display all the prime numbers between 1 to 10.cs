using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class Display_all_the_prime_numbers_between_1_to_10
    {
        static void Main(string[] args)
        {
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
                }
                if (isPrime == true)
                {
                    Console.WriteLine(i);
                }







            }
        }
    }
}

