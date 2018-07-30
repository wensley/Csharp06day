using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习
{
    /// <summary>
    /// 练习自定义常量枚举
    /// </summary>
    
        /*
        enum Sex
    {
        boy,
        girl
    }
    */
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Sex sex;
            sex = Sex.girl;
            Console.WriteLine("Please enter your gender?");
            string s = Console.ReadLine();
            try
            {
                sex = (Sex)(Enum.Parse(typeof(Sex), s));
                Console.WriteLine("Your enter gender "+sex);
            }
            catch
            {
                Console.WriteLine("Error");
            }
            */
            /*
            //练习1：从一个整数数组中取出最大的整数
            int[] number = new int[5];
            int max = 0;
            //对数组中元素进行赋值
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("请输入第{0}个人的成绩？", i + 1);
                number[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > max)
                {
                    max =number[i];
                }
            }
            Console.WriteLine("您输入的整数中最大的为：{0}",max);
            */
            /*
            //练习2 计算一个整数数组的所有元素的和
            int sum = 0;
            int [] number = new int[5];
            for(int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("请输入第{0}个整数",i+1);
                number[i] = Convert.ToInt32(Console.ReadLine());
                //sum += number[i];
            }
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            Console.WriteLine("整数数组的所有元素的和为：{0}",sum);
            */
            /*
            //练习3：将一个字符串数组输出为|分割的形式，比如”梅西|卡卡|郑大世“
            string[] name = new string[3];
            for (int i = 0; i != name.Length; i++)
            {
                Console.WriteLine("请输入第{0}个球员名字",i+1);
                name[i] = Console.ReadLine();
            }
            Console.WriteLine("{0}|{1}|{2}",name[0],name[1],name[2]);
            */
            /*
            //练习4：将一个整数数组的每一个元素进行如下的处理：如果元素是正数则将这个位置的元素的值加1，如果元素是负数则将这个位置的元素的值减1，如果元素是0，则不变。
            
            int[] number = new int[3];
            for(int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("请输入第{0}个整数",i+1);
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > 0)
                {
                    number[i] += 1;
                }
                if (number[i] < 0)
                {
                    number[i] -= 1;
                }
                if (number[i] == 0)
                {
                    number[i] += 0;
                }
            }
            Console.WriteLine("第一个数是{0}，第二个数是{1}，第三个数是{2}",number[0],number[1],number[2]);
            */
            //练习5：将一个字符串数组的元素的顺序进行反转。
                    
            Console.ReadKey();

        }
    }
}
