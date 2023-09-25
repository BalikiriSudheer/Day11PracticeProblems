using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    internal class Reverse
    {
        public void String()
        {
            Console.WriteLine("Please enter the Sentence");
            string username= Console.ReadLine();
            string reversedString = " ";
            for(int i =username.Length-1; i >= 0; i--)
            {
                reversedString += username[i];
            }
            Console.WriteLine("Reversed String is :"+reversedString);
        }
    }
}
