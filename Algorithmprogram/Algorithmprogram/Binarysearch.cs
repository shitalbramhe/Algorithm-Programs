using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmprogram
{
    internal class Binarysearch
    {
        public string[] SortingArray(string[] array)
        {
            int size = array.Length;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) > 0)
                    {
                        string temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        public void Display(string[] array)
        {
            foreach (string word in array)
            {
                Console.WriteLine(word);
            }
        }
        public void Binary_search(string[] sortedarray)
        {
            Console.WriteLine("Enter the string to be found:");
            string searchword = Console.ReadLine();
            int index = Binsearchword(searchword, sortedarray);
            if (index == -1)
                Console.WriteLine($"{searchword} not found in list");
            else
                Console.WriteLine($"{searchword} is found at index : {index} ");
        }
        public  int Binsearchword(string searchword, string[] sortedarray)
        {
            int low = 0;
            int high = sortedarray.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (sortedarray[mid] == searchword)
                    return mid;
                else if (searchword.CompareTo(sortedarray[mid]) > 0)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }
        
    }
}
