using System;

namespace Chris.CSharp.NewFeature.Foreach
{
    /// <summary>
    /// 在 C# 9 中增强了 foreach 的使用，使得一切对象都有 foreach 的可能
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var num = 123;
            foreach (var i in num)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
