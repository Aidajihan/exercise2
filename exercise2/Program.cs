﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        //array of integers to hold values
        private int[] Aida = new int[25];
        private int cmp_count = 0; //number of data comparasion
        private int mov_count = 0; //number of data movements

        //number of elements in array
        private int n;

        void read()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of elements in array : ");
                string s = Console.ReadLine();
                n = int.Parse(s);
                if (n <= 25)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 elements\n");


            }

        }
        }
    }

