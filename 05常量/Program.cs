using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05常量
{
    /// <summary>
    /// 定义了一个叫gender的枚举类型，他的值只有两个，男和女
    /// </summary>    
    enum gender
    {
        男,
        女
    }

    class Program
    {
        static void Main(string[] args)
        {
            gender sex;
            sex = gender.女;
            Console.WriteLine("请输入您的性别？");
            string s = Console.ReadLine();
            try
            {
                sex = (gender)(Enum.Parse(typeof(gender), s));
                Console.WriteLine("您输入的性别为："+sex);
            }
            catch
            {
                Console.WriteLine("您输入的性别有误！");
            }

            // (自定义枚举类型)(enum.Parse(typeof(自定义枚举类型),"待转换的字符串"));
            //Console.WriteLine(sex);
            Console.ReadKey();
                        
            //switch (sex)
            //{
            //    case gender.男:
            //        Console.WriteLine("男性");
            //        break;
            //    case gender.女:
            //        Console.WriteLine("女性");
            //        break;
            //}


            //const double PI = 3.14;  //常量


            //string gender = "男";
            //gender = "man";
            //gender = "男性";
            //gender = "男人";
            //if (gender == "男")
            //{

            //}


        }
    }
}
