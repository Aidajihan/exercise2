using System;
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
                    Console.WriteLine("\nArray can have maximum 25 elements\n");
            }
            Console.WriteLine("====================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("====================");

            //get array elements
            for (int i = 0; i < Aida.Length; i++)
            {
                Console.Write("<" + (Aida.Length + 1) + ">");
                string s1 = Console.ReadLine();
                Aida[i] = Int32.Parse(s1);
            }
        }
        //swaps the elements at index x with the element at index y

        void swap(int x, int y)
        {
            int temp;

            temp = Aida[x];
            Aida[x] = Aida[y];
            Aida[y] = temp;
        }
        public void q_sort(int low, int high, int mid)
        {
            int pivot, i, AF, k;
            if (low >= high) 
                return;
            

            //Partition the list into two parts:
            //one containing elements less that or equal to pivot
            //Outher containing elements greather than pivot

            i = low;
            AF = mid + 1;
            k = low;

            pivot = Aida[mid];

            while (k <= AF)
            {
                //search for an elements greater than pivot
                while ((Aida[i] <= Aida[k]) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                //Search for an element less than or equal to pivot
                while ((Aida[AF] > pivot) && (AF >= low))
                {
                    AF--;
                    cmp_count++;
                }
                cmp_count++;

                //if the greater element is on the left of the element
                if (i < AF)
                {
                    //Swap the element at index i whit the element at index j
                    swap(i, AF);
                    mov_count++;
                }
            }
            //AF now contains the index of thelast element in the sorted list

            if (Aida[low] <= Aida[AF])
            {

                //Move the pivot to its correct position in the list
                swap(low, AF);
                mov_count++;
            }
           
        }
        void display()
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine("Sorted Array elements");
            Console.WriteLine("\n---------------------");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(Aida[j]);
            }
            Console.WriteLine("\nNumber of comparisons: ", cmp_count);
            Console.WriteLine("\nNumber of data movemenets: " + mov_count);
        }


    }
}


