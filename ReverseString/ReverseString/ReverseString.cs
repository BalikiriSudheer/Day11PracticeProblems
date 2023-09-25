using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class ReverseString
    { public String Reverse(String st)
        {
            String result = " ";
            if (String.IsNullOrEmpty(st))
                return String.Empty; ;
            for (int i = st.Length - 1; i >= 0; i--)
            {
                result = result + st[i];


            }
            return result;

        } }
}
