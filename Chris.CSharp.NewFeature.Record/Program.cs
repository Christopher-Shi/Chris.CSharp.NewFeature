using System;

namespace Chris.CSharp.NewFeature.Record
{
    /// <summary>
    /// record 实现了基于值的相等性比较，并且实现了 原型模式，可以比较方便的创建一个新的值完全相等的对象，
    /// 这对于有一些业务场景来说是非常适合使用 record 来代替原来的实现的
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            {
                var student = new Student("a", "b", 1);
                var teacher = new Teacher("c", "d", "english");

                Console.WriteLine(student);
                Console.WriteLine(teacher);

                var studentCopy = student with { Level = 2 }; //with 实现了浅复制
                Console.WriteLine(studentCopy);
            }

            {
                var personOne = new Person
                {
                    LastName = "shi",
                    FirstName = "xiaoyong"
                };
                Console.WriteLine(personOne);

                var personTwo = new Person
                {
                    LastName = "shi",
                    FirstName = "xiaoyong"
                };
                Console.WriteLine(personTwo);

                Console.WriteLine($"personOne Equals personTwo =:{personOne == personTwo}");
            }

            Console.ReadLine();
        }
    }
}
