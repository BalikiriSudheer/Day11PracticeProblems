using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n=int.Parse(Console.ReadLine());
            Sum s=new Sum();
            s.SumDigits(n);
            Console.ReadLine();

        }
    }
}
