using System;

namespace LearningProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello("Vitalie");
            Console.WriteLine(CubeNumber(5));
            bool isMale = true;
            bool istall = true;

            if (isMale is false || istall)
            {
                SayHello("male");
            } else
            {
                SayHello("not male.");
            }
            Console.ReadLine();
        }

        static void SayHello(string name)
        {
            Console.WriteLine("Hi friend "+ name);
        }

        static int CubeNumber(int numberToCube)
        {
            int result = numberToCube * numberToCube * numberToCube;
            return result;
        }
    }
}
