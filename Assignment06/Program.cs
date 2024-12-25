using System;
using System.ComponentModel;
using System.Reflection;
using System.Threading.Channels;

namespace Assignment06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //Passing by Value
            //The reference itself(not the actual object) is passed as a copy to the method.
            //The method can modify the contents of the object because it operates on the same object.
            //However, if the reference is reassigned to a new object inside the method, this reassignment will not affect the original reference outside the method.

            //static void ByValue(int num)
            //{
            //    num = 50;
            //    Console.WriteLine("Inside PassByValue: " + num);
            //}

            //int x = 10;
            //Console.WriteLine("Before ByValue: " + x);
            //ByValue(x);
            //Console.WriteLine("After ByValue: " + x);
            ////Passing by Reference:
            ////The reference itself is passed directly to the method using the ref or out keyword.
            ////The method can modify the contents of the object and also reassign the reference to point to a new object.
            ////Changes to both the object’s contents and the reference will reflect outside the method.
            ////by Google
            //static void ByRef(ref int num)
            //{
            //    num = 50;
            //    Console.WriteLine("Inside ByRef: " + num);
            //}
            //int y = 10;
            //Console.WriteLine("Before ByRef: " + y);
            //ByRef(ref y);
            //Console.WriteLine("After ByRef: " + y);

            #endregion

            #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //static (int sum, int difference) Calc(int num1, int num2, int num3, int num4)
            //{
            //    int sum = num1 + num2;
            //    int difference = num3 - num4;
            //    return (sum, difference);
            //}

            //Console.WriteLine("Enter the num1:");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the num2:");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the num3");
            //int num3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the num4:");
            //int num4 = int.Parse(Console.ReadLine());

            //Console.WriteLine(Calc(num1, num2, num3, num4));

            #endregion
            #region Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //static void MinMaxArray(int[] num, ref int min, ref int max)
            //{
            //    min = num[0];
            //    max = num[0];

            //    foreach (int x in num)
            //    {
            //        if (x < min)
            //            min = x;
            //        if (x > max)
            //            max = x;
            //    }
            //}
            //int[] array = { 40, 57, 4, 8, 100, 1 };
            //int min = 0;
            //int max = 0;
            //MinMaxArray(array, ref min, ref max);
            //Console.WriteLine(min); 
            //Console.WriteLine(max);


            #endregion






        }
    }
}
