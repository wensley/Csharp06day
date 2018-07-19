using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06结构
{
    enum Sex
    {
        boy,
        girl
    }

    public struct Person    //定义一个名称叫Person的结构
    {
        public string name;     //结构的成员
        public Sex sex;            //结构的成员
        public int age;            //结构的成员
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person onePerson;
            onePerson.name = "Jim";
            onePerson.age = 20;
            onePerson.sex = Sex.boy;

            Person secPerson;
            secPerson.name = "MM";
            secPerson.age = 18;
            secPerson.sex = Sex.girl;

        }
    }
}
