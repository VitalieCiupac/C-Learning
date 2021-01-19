using System;

namespace LearningProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameValue = "John";
            int ageValue = 35;
            char firstLetter = 'V';

            double ag = 9.8;

            Console.WriteLine("ABC\nAFS\"D");
            Console.WriteLine(nameValue.IndexOf("gf"));
            Console.WriteLine(-98.376);

            Console.WriteLine(7 + 2);
            Console.WriteLine(7 * 2);

            Console.WriteLine(ageValue += 1);
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Sqrt(49));
            Console.WriteLine(Math.Round(4.6));

            
            

            

            Console.WriteLine("His name is: " + nameValue);
            Console.WriteLine("His age is: " + ageValue);
            ageValue = 25;
            Console.WriteLine("His age is: " + ageValue);
            Console.WriteLine("First character: "+ firstLetter);
            Console.WriteLine("Acceleratia gravitationala este egala cu: " + ag);
           
            Console.ReadLine();
        }
    }
}
