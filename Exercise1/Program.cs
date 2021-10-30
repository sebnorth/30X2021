﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    /// <summary>
    /// Exercise 1 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Tests LastIndexOf and AllIndexesOf methods
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // build test dynamic array
            UnorderedIntDynamicArray tablica = new UnorderedIntDynamicArray();
            tablica.Add(3);
            tablica.Add(5);
            tablica.Add(2);
            tablica.Add(1);
            tablica.Add(3);
            tablica.Add(3);

            // test LastIndexOf with one item in dynamic array

            // test LastIndexOf with multiple items in the dynamic array

            // test LastIndexOf with item not in dynamic array

            // test AllIndexesOf with one item in dynamic array

            // test AllIndexesOf with multiple items in dynamic array

            // test AllIndexesOf with item not in dynamic array

            Console.ReadKey();
        }
    }
}
