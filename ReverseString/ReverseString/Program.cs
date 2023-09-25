using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            
            string result = string.Empty;
            Console.Write("Enter the String");
            string st=Console.ReadLine();
            string[] arr = st.Split();
            
            for(int i=0; i<arr.Length; i++) {
                if (i != arr.Length - 1)
                {
                    result = result + ReverseString(arr[i]) + " ";

                }
                else
                {
                    result = result + ReverseString(arr[i]);
                }
                Console.WriteLine("Reverse a string:{0}",result);
                Console.ReadLine();
            }

        }

        static string ReverseString(string st)
        {
            string result = " ";
            if (string.IsNullOrEmpty(st))
                return string.Empty; ;
            for (int i = st.Length - 1; i >= 0; i--)
            {
                result = result + st[i];


            }
            return result;
            ;
        }
    }
    }

