using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //27复习习题讲解（try-catch）：08：00——26：00
            int age = 0;
            bool isName = false;
            Console.WriteLine("请输入您的年龄：");
            while (isName = false)
            {
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age >= 0 && age <= 100)
                    {
                        isName = true;
                    }
                    else
                    {
                        Console.WriteLine("年龄只能输入0-100，请重新输入！");
                        isName = false;
                    }
                    catch
                {
                    Console.WriteLine("您刚刚输入的不是数字！");
                    isName = false;
                }
            }
            Console.ReadKey();
        }
       */

            //for (int i = 0; i < 10; i++)
            //{
            //    //外层循环，循环10次

            //    //写在这里的代码，属于外层循环
            //    Console.WriteLine("这是外层循环，在内层循环前面");
            //    for (int j = 0; j < 5; j++)
            //    {
            //        //内层循环，循环5次
            //        //这里是内层循环的代码
            //        Console.WriteLine("内层循环");

            //    }
            //    Console.WriteLine("这是外层循环，在内层循环前面");
            //    //写在这里的代码，属于外层循环
            //}
            /*
            //问题3 下面是老师讲解演示的矩形
            for (int i = 1; i <=9; i++)
            {
                //外层循环控件行数  即i代表行号
                for (int j = 1; j <= 9; j++)
                {
                    //第i行的第j个式子
                    Console.Write("{0}*{1}={2:00}  ",i,j,i*j);
                }
                Console.WriteLine(  );  
            }
            Console.ReadKey();

            //问题3 下面是老师讲解演示的梯形
            for (int i = 1; i <= 9; i++)
            {
                //外层循环控件行数  即i代表行号
                for (int j = 1; j <= i; j++) //j<=i时即可输出梯形
                {
                    //第i行的第j个式子
                    Console.Write("{0}*{1}={2:00}  ", i, j, i * j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */
            /*
            //问题3 下面是我写的矩形
            
        int a = 1;
        int b = 1;
        //int sum = 0;
        for (a = 1; a <= 9; a++)
        {
            for (b = 1; b <= a; b++)//b <= a;即可输出梯形
                {                     //if (a <= 9 || b <= 9)//其实根本不用加if
                                    //{
                                    //sum = a * b;
                    Console.Write("{0}*{1}={2:00}  ", a, b, a*b);//占位符2后面的“：00”表示强制为两位数
                    //b++;
                }
                Console.WriteLine();
        }
        */
            //27复习习题讲解 -练习1:输入一个数字6，列出和等于数字6的所有式子
            /*
            //我做的方案一   //没有考虑输入错误，没有循环
            Console.WriteLine("请输入一个值：");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= input; i++)
            {
                for (int j = 0; j <= input; j++)
                {
                    if (i + j == input)//(i+j=input)错误: CS0131  赋值号左边必须是变量、属性或索引器。应该是两个等号，单个=号是赋值！！！
                    {
                        Console.WriteLine("{0}+{1}={2}", i, j, i + j);

                    }
                }
            }
            Console.ReadKey();
            */
            //我做的方案二，没有循环。。。
            /*
            Console.WriteLine("请输入一个值：");
            int input = 0;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= input; i++)
                {
                    for (int j = 0; j <= input; j++)
                    {
                        if (i + j == input)
                        {
                            Console.WriteLine("{0}+{1}={2}", i, j, i + j);

                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("您输入的不是数字，请重新输入！");
            }
            Console.ReadKey();
            */
            /*
            //老师演示的
            Console.WriteLine("请输入一个值：");
            int input = 0;
            bool number = false;
            while (number == false)
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    number = true;
                }
                catch
                {
                    Console.WriteLine("您输入的不是数字，请重新输入！");
                    number = false;
                }
            }
            for (int i = 0; i < input + 1; i++)
            {
                Console.WriteLine("{0}+{1}={2}", i, input - i, input);
            }
            Console.ReadKey();
            */

        }
    }
}
