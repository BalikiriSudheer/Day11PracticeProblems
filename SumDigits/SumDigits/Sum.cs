using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    internal class Sum
    {
        public void SumDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                int d = n % 10;
                sum = sum + d;
                n = n / 10;
            }
            Console.WriteLine(sum);

        }

    }
        }
 
