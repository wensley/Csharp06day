using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07数组
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //输出数组中的每一个元素的值
            int sum = 0;
            int[] score = new int[10];
            //对数组中元素进行赋值
            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine("请输入第{0}个人的成绩？",i+1);
                score[i] = Convert.ToInt32(Console.ReadLine());
                //sum=sum+score[i];  直接这里累加也可以
            }
            //通过一个循环，求一个数组中所有元素的和
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.Clear(); //可以清屏
            Console.WriteLine("{0}个人的平均成绩为：{1}",score.Length,sum/score.Length);
            //输出数组中的每一个元素的值
            for(int i = 0; i < score.Length; i++)
            {
                Console.WriteLine("第{0}个学生的成绩为{1}分",i+1,score[i]);
            }
            Console.ReadKey();
            */
            //string[] names = { "张三","李四","王五"};//声明后直接赋初值

            /*
            //求输入中的最大值
            int max;
            int sum = 0;
            int[] score = new int[10];
            //对数组中元素进行赋值
            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine("请输入第{0}个人的成绩？", i + 1);
                score[i] = Convert.ToInt32(Console.ReadLine());
                //sum=sum+score[i];  直接这里累加也可以
            }

            //求最大值
            max = score[0];
            for (int i = 1; i < score.Length; i++)
            {
                if (score[i] > max)
                {
                    max = score[i];
                }
            }
            //通过一个循环，求一个数组中所有元素的和
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.Clear(); //可以清屏
            Console.WriteLine("{0}个人的平均成绩为：{1}", score.Length, sum / score.Length);
            //输出数组中的每一个元素的值
            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine("第{0}个学生的成绩为{1}分", i + 1, score[i]);
            }
            //输出数组中的最大的值
            Console.WriteLine("最高分为：{0}",max);
            Console.ReadKey();
            */

        }
    }
}
