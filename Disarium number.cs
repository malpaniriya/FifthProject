using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class Disarium_number
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int count = 0;
            int sum = 0;

            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            
            
            num = temp;
            while(num>0)
            {
                int digit = num % 10;
                int power = 1;
                for(int i=1;i<=count;i++)
                {
                    power = power * digit;
                }
                sum = sum + power;
                count--;
                num = num /10;
            }
            if (temp==sum)
            {
                Console.WriteLine("Disarium Number");
            }
            else
            {
                Console.WriteLine("It is not disarium number");
            }





        }
        }
    }

