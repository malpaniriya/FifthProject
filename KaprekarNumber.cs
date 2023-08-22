using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class KaprekarNumber
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int count = 0;
            int sq = num * num;
            while(num>0)
            {
                count++;
                num = num / 10;
            }
            int power = 1;
            for(int i=1;i<=count;i++)
            {
                power = power * 10;
            }
            int end = sq % power;
            int start = sq / power;
            int sum = end + start;
          
            if(sum==temp)
            {
                Console.WriteLine("Kaprekar Number");
            }
            else
            {
                Console.WriteLine("It is not Kaprekar number");
            }





        }
    }
}


        
