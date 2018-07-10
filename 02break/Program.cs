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
            if (isAge == true)
            {
                Console.WriteLine("您输入的5个人的平均年龄为：{0}", sum / 5);
               
            }
            Console.ReadKey();
        }
    }
}
