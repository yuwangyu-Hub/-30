using System;

namespace 极夜30
{
    class Program
    {
        static void Main(string[] args)
        {
            Person 张华 = new Person("张华",'男',20);
            Console.WriteLine($"他的名字叫{张华.Name},他是{张华.Gender},他今年{张华.Age}岁!");
            Console.ReadLine();
        }
    }
}
