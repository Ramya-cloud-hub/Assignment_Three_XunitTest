using System;

namespace Assignment_Three_CalculatorDemo
{
    class Calculator
    {
        static void Main(string[] args)
        {
            double[] arr = { 10, 5, 5, 10, 5 };
       
            double addResult = Add(arr);
            double subResult = Sub(arr);
            double divResult = Div(100, 10);
            double mulResult = Mul(5, 10);

            Console.WriteLine("Addition of given array is: \t" + addResult);
            Console.WriteLine("subtraction of given array is: \t" + subResult);
            Console.WriteLine("Multiplication of given two number is: \t" + mulResult);
            Console.WriteLine("Division of given two number is: \t" + divResult);
        }

        public static double Mul(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Div(double num1, double num2)
        {
            if (num1 == 0 || num2 == 0)
            {
                //costoom business logic for divide by zero
                Console.WriteLine("It is bad idea if you divide number by zero");
                return 0;
            }
            else
            {
                return num1 / num2;
            }

        }
        public static double Add(double[] list)
        {
            double result = 0;
            for (int i = 0; i < list.Length; i++)
            {
                result += list[i];
            }
            return result;
        }
        public static double Sub(double[] list)
        {
            double result = 0;
            for (int i = 0; i < list.Length; i++)
            {
                result = list[i] - result;
                Console.WriteLine(list[i]);
            }
            return result;
        }
    }
}
