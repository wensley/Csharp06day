using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04三元表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //二元运算例子：
            int a = 10;
            int b = 10;
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
            */

           // 三元运算
            //int a = 10;
            //int b = 20;

            //int max = a > b ? a : b;
            //Console.WriteLine(max);
            //上面两行代码可以简化为下面一句
            int a = 10;
            int b = 20;
            Console.WriteLine(a > b ? a : b);


            Console.ReadKey();
        }
    }
}
