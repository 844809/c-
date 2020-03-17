using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace words
{
    class numtoword
    {
        
            public string numbertoword(int n)
            {
                int reves = rev(n);
                int b = n.ToString().Length;
            string[] words = { "zero ", "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine " };
                string numword = "";
                for (int i = 0; i < b; i++)
                {
                    int num = reves % 10;
                    reves = reves / 10;
                    for (int j = 0; j < words.Length; j++)
                    {
                        if (num == j)
                        {
                            numword += words[j];

                        }
                    }
                }
                return numword;
            }
            public int rev(int n)

            {
                int rev = 0, remainder = 0;
                while (n != 0)
                {
                    remainder = n%10;
                    rev = rev * 10 + remainder;
                    n /= 10;
                }
                return rev;
            }
        
    }
}

