using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06结构
{
    
    public enum Sex
    {
        boy,
        girl
    }
    /*
    public struct Person    //定义一个名称叫Person的结构
    {
        public string name;     //结构的成员
        public Sex sex;            //结构的成员
        public int age;            //结构的成员
    }
    */

    /* 练习1
public struct Mycolor
{
    public string red;
    public string green;
    public string blue;
}
*/
    //练习2
    public struct Person
    {
        public string name;
        public Sex sex; //错误 CS0052  可访问性不一致: 字段类型“Sex”的可访问性低于字段“Person.sex”	
        //对于此错误的说明见 32课26：00。简单说就是Sex不是public，无法调用Sex，在enum前加publi即可
        public int age;

    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Mycolor color;
            //color.blue = "蓝色";
            color.red = "红色";
            //color.green = "绿色";
            //Console.WriteLine("请输入一个颜色（red，blue，green）");
            //string c = Console.ReadLine();
           
                //color = (Mycolor)(Enum.Parse(typeof(Mycolor), c));
                Console.WriteLine("您输入的颜色是"+color.red);
           
            Console.ReadKey();
            */
            //练习2
            Person onePerson;
            onePerson.name = "张三";
            onePerson.sex = Sex.boy;
            onePerson.age = 18;

            Person twoPerson;
            twoPerson.name = "小兰";
            twoPerson.sex = Sex.girl;
            twoPerson.age = 16;

            //没讲结构的练习题

            Console.ReadKey();

            


            /*
            Person onePerson;
            onePerson.name = "Jim";
            onePerson.age = 20;
            onePerson.sex = Sex.boy;

            Person secPerson;
            secPerson.name = "MM";
            secPerson.age = 18;
            secPerson.sex = Sex.girl;
            */





        }
    }
}
