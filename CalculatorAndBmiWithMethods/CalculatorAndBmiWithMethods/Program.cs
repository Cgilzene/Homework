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
                float value1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                float value2 = float.Parse(Console.ReadLine());
                double sum;
                Console.WriteLine("Enter the opperation, + , -, * , / " );

                String Operations = Console.ReadLine();

                switch (Operations)
                {
                    case "+":
                         sum = calculations.Addition(value1, value2);
                        Console.WriteLine("The Answer is: " + sum);
                        break;
                    case "-":
                        sum = calculations.Subtraction(value1, value2);
                        Console.WriteLine("The Answer is: " + sum);
                        break;
                    case "*":
                        sum = calculations.multiplication(value1, value2);
                        Console.WriteLine("The Answer is: " + sum);
                        break;
                    case "/":
                        sum = calculations.Division(value1, value2);
                        Console.WriteLine("The Answer is: " + sum);
                        break;
                }


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
        public double Addition(float value1, float value2)
        {
            double sum = value1 + value2;

            return sum;
        }
        public double Subtraction(float value1, float value2)
        {
            double sum = value1 - value2;

            return sum;
        }
        public double multiplication(float value1, float value2)
        {
            double sum = value1 * value2;

            return sum;
        }
        public double Division(float value1, float value2)
        {
            double sum = value1 / value2;

            return sum;
        }

    }
}
    

