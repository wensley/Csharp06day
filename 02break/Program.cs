using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02break
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //练习1
            int age = 0;
            int sum = 0;
            bool isAge = false;
            for (int i=0;i<5 ;i++)
            {
                Console.WriteLine("请输入5个人的年龄，第{0}个人的年龄为：",i+1);
                try
                {
                    //Console.WriteLine("请输入5个人的年龄：");应该写到外面
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age < 0 || age >= 100)
                    {
                        Console.WriteLine("非法数据！");
                        isAge = false;
                        break;
                    }
                    sum = sum + age;
                    isAge = true;
                    
                }
                catch
                {
                    Console.WriteLine("您输入的不是数字，程序终止");
                    isAge = false;
                    break;
                }
            }
            //如果通过break跳出循环，i<5肯定是成立的。
            //如果程序执行到这里，并且退出循环不是由于执行了break引起的，那么一定是循环条件不成立了！
           
            if(i<5==false)
            //if (isAge == true) 我用标志位方式
            {
                Console.WriteLine("您输入的5个人的平均年龄为：{0}", sum / 5);
               
            }
            Console.ReadKey();
            */
            /*
            //老师的方案，通过for循环的条件来判断是否输出平均年龄
            int age = 0;
            int sum = 0;
            int i=0;
            for (i = 0; i < 5; i++)//i变成了赋值条件
            {
                Console.WriteLine("请输入5个人的年龄，第{0}个人的年龄为：", i + 1);
                try
                {
                    //Console.WriteLine("请输入5个人的年龄：");应该写到外面
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age < 0 || age >= 100)
                    {
                        Console.WriteLine("非法数据！");

                        break;
                    }
                    sum = sum + age;
                }
                catch
                {
                    Console.WriteLine("您输入的不是数字，程序终止");
                    break;
                }
            }
            //如果通过break跳出循环，i<5肯定是成立的。
            //如果程序执行到这里，并且退出循环不是由于执行了break引起的，那么一定是循环条件不成立了！
            if (i < 5 == false) //i<5如果成立，说明
            {
                Console.WriteLine("您输入的5个人的平均年龄为：{0}", sum / 5);

            }
            Console.ReadKey();
            */
            //练习2
            /*
            string userName="";
            string passWord="";

            while(true) //(userName != "admin" || passWord != "888888")
            {
                    Console.WriteLine("请输入用户名：");
                    userName = Console.ReadLine();
                    Console.WriteLine("请输入密码：");
                    passWord = Console.ReadLine();
                if (userName == "admin" && passWord == "888888")
                {
                    Console.WriteLine("登陆成功");
                    break;
                }
                else
                {
                    Console.WriteLine("用户名或密码错误！请重新输入");
                }
            }
            Console.ReadKey();
            */

            //练习3：1-100之间整数相加，得到累加值大于20的当前数
            /*  我的做错了
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i%2==0)
                {
                    sum = sum + i;
                    if (sum >= 20)
                    {
                        Console.WriteLine("1-100之间整数相加，累加值大于20的当前数为：" + sum);//应该是显示i的值
                    }
                }
            }
            Console.ReadKey();
            */
            //老师的方案
            int sum = 0;
             int i=0;
            for ( i = 1; i <= 100; i++)
            {
                    sum = sum + i;
                    if (sum >= 20)
                    {
                    break;
                    }
            }
            Console.WriteLine("1-100之间整数相加，累加值大于20的当前数为：" + i);
            Console.ReadKey();

        }
    }
}
