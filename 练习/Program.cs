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
    
        enum Sex
    {
        boy,
        girl
    }

    class Program
    {

        static void Main(string[] args)
        {
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
            Console.ReadKey();

        }
    }
}
