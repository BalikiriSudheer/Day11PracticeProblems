﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class ReverseTriangle
    {
       public void Triangle( int n)
        {
            
            for(int i = n; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            
        }
    }
}
