using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            while (i <= 100)
            {
                if(i%7==0)
                {
                    i++;//如果不加就是死循环，i一直等于7
                    continue;
                }
                sum += i;
                i++;
            }
            Console.WriteLine("sum="+sum);
            Console.ReadKey();
        }
    }
}
