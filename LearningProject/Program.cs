using System;

namespace LearningProject
{
    class Program
    {
        static void Main(string[] args)
        {
            exceptionH(5,0);
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

        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        static string SwitchMet(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Monday";
                    break;
                case 1:
                    dayName = "Tuesday";
                    break;
                case 2:
                    dayName = "Wednesday";
                    break;
                case 3:
                    dayName = "Thursday";
                    break;
                case 4:
                    dayName = "Friday";
                    break;
                case 5:
                    dayName = "Saturday";
                    break;
                case 6:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid number";
                    break;
            }

            return dayName;
        }

        static void whileMeth(string word, int times)
        {
            int index = 1;
            while (index <= times)
            {
                Console.WriteLine(word);
                index++;
            }

        }

        static void forLoops(int numb)
        {
            for(int i=0; i<=numb; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void dArray()
        {
            int[,] numberGrid = {
            { 1,2,3},{ 4,5,6},{ 7,8,9}
            };

            Console.WriteLine(numberGrid[0,1]);
        }

        static void exceptionH(int num1, int num2)
        {
            try
            {

                Console.WriteLine(num1 / num2);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
