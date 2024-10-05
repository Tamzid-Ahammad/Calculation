using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If we  use static in Summation,Subtraction,Multiplication,Division method and wanted to call those method into an  Static Method

            //Console.WriteLine("Please provide the value for x ");
            //var x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Now please provide the value for y ");
            //var y = Convert.ToDouble(Console.ReadLine());

            //var resultForSummation = Summation(x, y);
            //Console.WriteLine("The result of the summation is: " + resultForSummation);

            //var resultForSubtraction = Subtraction(x, y);
            //Console.WriteLine("The result of the subtraction is: " + resultForSubtraction);

            //var resultForMultiplication = Multiplication(x, y);
            //Console.WriteLine("The result of the multiplication is: " + resultForMultiplication);

            //var resultForDivision = Division(x, y);
            //Console.WriteLine("The result of the Division is: " + resultForDivision);

            //Console.ReadLine();

            //If we don't use static in Summation,Subtraction,Multiplication,Division method but wanted to call those method into  an Static Method

            Program program = new Program();

            Console.WriteLine("Please provide the value for x ");
            var x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now please provide the value for y ");
            var y = Convert.ToDouble(Console.ReadLine());

            var resultForSummation = program.Summation(x, y);
            Console.WriteLine("The result of the summation is: " + resultForSummation);

            var resultForSubtraction = program.Subtraction(x, y);
            Console.WriteLine("The result of the subtraction is: " + resultForSubtraction);

            var resultForMultiplication = program.Multiplication(x, y);
            Console.WriteLine("The result of the multiplication is: " + resultForMultiplication);

            var resultForDivision = program.Division(x, y);
            Console.WriteLine("The result of the Division is: " + resultForDivision);

            Console.ReadLine();

        }
        //public static double Summation(double x, double y)
        //{
        //    return x + y;
        //}
        //public static double Subtraction(double x, double y)
        //{
        //    return x - y;
        //}
        //public static double Multiplication(double x, double y)
        //{
        //    return x * y;
        //}
        //public static double Division(double x, double y)
        //{
        //    return x / y;
        //}
        public  double Summation(double x, double y)
        {
            return x + y;
        }
        public  double Subtraction(double x, double y)
        {
            return x - y;
        }
        public  double Multiplication(double x, double y)
        {
            return x * y;
        }
        public  double Division(double x, double y)
        {
            return x / y;
        }
    }
}
