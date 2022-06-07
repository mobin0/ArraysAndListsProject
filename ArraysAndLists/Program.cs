using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var intArray = new int[10] { 1, 2, 3 ,4,5,6,7,8,9,10};
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var eList = new List<int>() {}; ;
            var oList = new List<int>() { };
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (int i in intArray) {
                bool e = (i % 2 == 0);
                if (e) { eList.Add(i); } else { oList.Add(i); } 
            }
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Printing Evens List:");
            foreach (int i in eList)
            { 

                
                Console.WriteLine(i);
            }
            Console.WriteLine("Printing Odds List:");
            foreach (int i in oList)
            { 
             
                Console.WriteLine(i);
            }

        }
    }
}
