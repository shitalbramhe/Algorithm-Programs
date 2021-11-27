using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmprogram
{
    internal class Bubblesort
    {
        public int[] Sort(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
              //  int count = 0;
                for (int j = 0; j < length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        //count++;
                    }
                }
               /* if (count == 0)
                {
                    break;
                }*/
            }
            return array;
        }
        public void Display(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}

