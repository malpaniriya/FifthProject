﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class Print10101010101
    {
        //print
        //10101
        //01010
        //10101
        //01010
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)//row
            {
                if (i % 2 != 0)
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("0");
                        }
                        else
                        {
                            Console.Write("1");
                        }

                    }
                }
                else
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("1");

                        }
                        else
                        {
                            Console.Write("0");
                        }
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
