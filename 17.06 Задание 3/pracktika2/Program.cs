using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracktika2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            myClass.change = "Не изменено";
            myStruct.change = "Не изменено";
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
            Console.ReadKey();
        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Изменено";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "Изменено";
        }
    }
    struct MyStruct
    {
        public string change;
    }
}

