// See https://aka.ms/new-console-template for more informatio
using System.Data.Common;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System;

namespace Exam3
{
    public class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("programstart");
            Console.WriteLine("Task1");
            task1runner();
            Console.WriteLine("task2");
            Console.WriteLine($"{task2.ArrayFlattener()}");
            Console.WriteLine("task3");
            task3 task3 = new task3();
            task3.reader();
            task3.SummarizeFunction();
            Console.WriteLine("task4");
            task4 task4 = new task4();
            task4.runTask4();



        }
        public static void task1runner(){
        Console.WriteLine($"{SquarifyNumber(10)} \n {ConvertInchToMm(10)} \n {RootifyNumber(10)} \n {CubeifyNumber(10)} \n {CalculateRadiusOfACircle(10)} \n {GreetingsSir("Christian")} ");
        }
        public static double SquarifyNumber(double Number)
        {

            return Number * Number;
        }

        public static double ConvertInchToMm(double Inches)
        {
            double ConvertionConstant = 25.4;
            return Inches * ConvertionConstant;
        }

        public static int RootifyNumber(int Number)
        {
            for (int i = 0; i < Number; i++)
            {
                if (i * i == Number)
                {
                    return i;
                }

            }
            Console.WriteLine("Error this function only supports whole numbers something wrong happened");
            return 0;
        }
        public static double CubeifyNumber(double Number)
        {

            return Number * Number * Number;
        }
        public static double CalculateRadiusOfACircle(double Radius)
        {
            double Pi = 3.14159;
            double NoMagicTwo = 2;
            return NoMagicTwo * Pi * Radius;
        }
        public static string GreetingsSir(string Name)
        {
            string GreetingName = $"Hello there {Name} Fancy seeing you here";
            return GreetingName;
        }
        
    }
}