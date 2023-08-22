using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class DuckNUmber
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int rem = 0, count = 0;
            while(num!=0)
            {
                rem = num % 10;
                num = num / 10;
                if(rem==0)
                {
                    count++;

                }
            }
            if(count==1)
            {
                Console.WriteLine("Duck Number");
            }
            else
            {
                Console.WriteLine("It is not duck number");
            }
        }
        


        


    }

}
