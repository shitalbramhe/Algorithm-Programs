using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmprogram
{
    internal class Anagramdetection
    {
        public void CheckAnagram()
        {
            Console.WriteLine("Enter first strings");
            string firststring = Console.ReadLine();
            Console.WriteLine("firststring :" + firststring);
            char[] firstarray = firststring.ToLower().ToCharArray();

            Console.WriteLine("Enter second strings");
            string secondstring = Console.ReadLine();
            Console.WriteLine("secondstring :" + secondstring);
            char[] secondarray = secondstring.ToLower().ToCharArray();

            Array.Sort(firstarray);
            Array.Sort(secondarray);

            string val1 = new string(firstarray);
            string val2 = new string(secondarray);

            if (val1 == val2)
            {
                Console.WriteLine($"{firststring} and {secondstring} are Anagrams");
            }
            else
            {
                Console.WriteLine($"{firststring} and {secondstring} are not Anagrams");
            }
        }
    }
}

  