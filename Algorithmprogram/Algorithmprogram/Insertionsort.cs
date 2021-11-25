using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmprogram
{
    public class Insertionsort
    {
        public void Display(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }
        public string[] Insertsort(string[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                string temp = array[i];
                int j = i - 1;
                while (j >= 0 && array[j].CompareTo(temp) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
            return array;
        }
    }
}
