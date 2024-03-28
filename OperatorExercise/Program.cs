using System;
using System.ComponentModel;

namespace OperatorsInClass
{
    class program

    {
        public static int Add(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Subtract(int num1, int num2)
        {
            var answer = num1 - num2;
            return answer;
        }

        public static int times(int num1, int num2)
        {
            var answer = num1 * num2;
            return answer;

        }
        public static int divide(int num1, int num2)
        {
            var answer = num1 / num2;
            return answer;
        }
        static void main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");


            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));
        }

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }


}

