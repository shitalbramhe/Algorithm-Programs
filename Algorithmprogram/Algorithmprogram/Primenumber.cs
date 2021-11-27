using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmprogram
{
    public class Primenumber
    {
        public void Prime()
        {
            long range = 1000;
            Console.WriteLine("Prime Numbers");
            if (range <= 1)
                Console.WriteLine("Invalid Number");
            else
            {
                for (int i = 1; i <= range; i++)
                {
                    int flag = 1;

                    for (int j = 2; j <= i / 2; ++j)
                    {
                        if (i % j == 0)
                        {
                            flag = 0;
                            break;
                        }
                    }

                    // flag = 1 means i is prime
                    // and flag = 0 means i is not prime
                    if (flag == 1)
                        Console.WriteLine(i);
                }
            }
        }
    }
}
