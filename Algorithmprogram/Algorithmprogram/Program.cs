﻿using System;

namespace Algorithmprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Program number to get executed \n1. Insertion sort \n2. Bubble sort \n3. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        string[] array = { "hello", "how", "are", "you" };
                        Console.WriteLine("Unsorted Array");
                        Insertionsort obj = new Insertionsort();
                        obj.Display(array);
                        Console.WriteLine("Sorted array");
                        string[] sortedarray = obj.Insertsort(array);
                        obj.Display(sortedarray);
                        break;
                    case 2:
                        int[] arr = { 25, 14, 4, 7, 5 };
                        Console.WriteLine("Unsorted array");
                        Bubblesort bubble = new Bubblesort();
                        bubble.Display(arr);
                        Console.WriteLine("Sorted array");
                        int[] sortedArray = bubble.Sort(arr);
                        bubble.Display(sortedArray);
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }
            }
        }
    }
}