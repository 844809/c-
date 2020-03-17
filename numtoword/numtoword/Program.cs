using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numtoword
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,next,ndigit;
            int[] a = new int[10];
            string[] digits_words={ "zero","one","two","three","four","five","six","seven","eight","nine"};
            Console.WriteLine("enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numbertoword:" +n);
            Console.WriteLine("number in words:");
            next = 0;
            ndigit = 0;
            do
            {
                next = n % 10;
                a[ndigit] = next;
                ndigit++;
                n = n / 10;

            }
            while (n > 0);
            ndigit--;
            for (; ndigit >= 0; ndigit--) ;
            Console.Write(digits_words[a[ndigit]] + " ");
            Console.ReadLine();
        }
    }
}
