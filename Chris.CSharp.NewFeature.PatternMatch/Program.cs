using System;

namespace Chris.CSharp.NewFeature.PatternMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new()
            {
                LastName = "shi",
                FirstName = "chris",
                Age = 26
            };

            // and
            // !string.IsNullOrEmpty(person.Description)
            var isExist = person.FirstName is not null and { Length: > 0 };

            // or
            // string.IsNullOrEmpty(person.Description)
            var isEmpty = person.FirstName is null or { Length: 0 };


            //switch
            switch (person.Age)
            {
                case >= 0 and <= 3:
                    Console.WriteLine("baby");
                    break;
                case > 3 and < 14:
                    Console.WriteLine("child");
                    break;
                case > 14 and < 22:
                    Console.WriteLine("youth");
                    break;
                case > 22 and < 60:
                    Console.WriteLine("Adult");
                    break;
                case >= 60 and <= 500:
                    Console.WriteLine("Old man");
                    break;
                case > 500:
                    Console.WriteLine("monster");
                    break;
            }

            Console.ReadLine();
        }
    }
}
