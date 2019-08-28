using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAndBmiWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select 1 for Calculator or 2 for BMI Calculator");
            int option1 = int.Parse(Console.ReadLine());

            if (option1 == 1)
            {
                Calc calculations = new Calc();
                Console.WriteLine("Welcome To Calculator");
                Console.WriteLine("Please enter the first number");
                int value1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                int value2 = int.Parse(Console.ReadLine());
                double sum = calculations.Addition(value1, value2);
                Console.WriteLine("The Answer is: " + sum);



            }
            else if (option1 == 2)
            {

            }
            else
            {

            }


            Console.Read();
        }
    }
    class Calc
    {
        public double Addition(int value1, int value2)
        {
            double sum = value1 + value2;

            return sum;
        }
        public double Subtraction(int value1, int value2)
        {
            double sum = value1 - value2;

            return sum;
        }
        public double multiplication(int value1, int value2)
        {
            double sum = value1 * value2;

            return sum;
        }
        public double Division(int value1, int value2)
        {
            double sum = value1 / value2;

            return sum;
        }

    }
}
    

