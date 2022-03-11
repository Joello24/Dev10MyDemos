using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class Exercises
    {
        public void GetLastElement()
        {
            //Given an array larger than 0, return the last element in the array
            int[] integers = { 1, 2, 3, 4, 5, 7, 8, 9 };
            // Indices         0  1  2  3  4  5  6  7
            // Length 8

            Console.WriteLine(integers[integers.Length - 1]);
        }

        public void FillArray()
        {
            //Given an empty array, fill each element with the index + 1
            int[] integers = new int[10];

            for(int idx = 0; idx < integers.Length; idx++)
            {
                integers[idx] = idx + 1;
            }

        }

        public void GrowArray()
        {
            //Given an array, and n. Add more slots to an array.
            //eg. An array with 5 elements, and additional elements = 2,
            //return an array with 7 elements.
            int[] integers = { 1, 2, 3, 4, 5 };
            //        indices  0  1  2  3  4
            int additional = 2;
            //                               5 6


            //Allocate a new array of correct length
            int[] newArray = new int[integers.Length + additional];

            //Copy values from old array into new array
            for (int idx = 0; idx < integers.Length; idx++)
            {
                newArray[idx] = integers[idx];
            }

            //Set old array variable to point to new array
            integers = newArray;

            foreach(int i in integers)
            {
                Console.WriteLine($"{i}");
            }
        }

        public void HalfArray()
        {

        }
    }

}
