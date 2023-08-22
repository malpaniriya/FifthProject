using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class FrequencyOfDigit
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int copy = 0;
            
           
             copy = num;
            for(int i=0;i<=9;i++)
            {
                int count = 0;
                while(num>0)
                {
                    int digit = num % 10;
                    if(digit==i)
                    {

                        count++;
                    }

                    num = num / 10;

                }
                   if(count!=0)
                {
                    Console.WriteLine(i + " " + count);
                    

                }
                num = copy;


            }

        }
        }
    }

