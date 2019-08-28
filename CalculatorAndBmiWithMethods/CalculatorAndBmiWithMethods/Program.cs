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
            string exit = "exit";
            //while (exit == "exit")
            //{
                Console.WriteLine("Please Select 1 for Calculator or 2 for BMI Calculator");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Calc calculations = new Calc();

                    Console.WriteLine("Welcome To Calculator");

                    Console.WriteLine("Please enter the first number");

                    float value1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the second number");

                    float value2 = float.Parse(Console.ReadLine());

                    double sum;

                    Console.WriteLine("Enter the opperation, + , -, * , / ");

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
                else if (option == 2)
                {
                    BMIcalc bmi = new BMIcalc();

                    Console.WriteLine("Please enter your height in cm");
                    float heightInCm = float.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your weight in kg");
                    float weightInKg = float.Parse(Console.ReadLine());

                    bmi.BMI(weightInKg, heightInCm);
                }
                else
                {
                    Console.WriteLine("please enter either 1 or 2");
                }
                //Console.Read();
           // }

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
    class BMIcalc
    {
        public double BMI(float weightInKg, float heightInCm)
        {
           
            double BmiTotal = (weightInKg / (heightInCm * heightInCm)) * 10000; // bmi calculation = weight / height squared

            if (BmiTotal < 18.5)
            {
                Console.WriteLine("Your BMI is: ");
                Console.WriteLine(BmiTotal);
                Console.WriteLine("You are underweight");
            }
            else if (BmiTotal >= 18.5 & BmiTotal <= 24.9)
            {
                Console.WriteLine("Your BMI is: ");
                Console.WriteLine(BmiTotal);
                Console.WriteLine("You are healthy");
            }
            else if (BmiTotal >= 25 & BmiTotal <= 29.9)
            {
                Console.WriteLine("Your BMI is: ");
                Console.WriteLine(BmiTotal);
                Console.WriteLine("You are overweight");
            }
            else if (BmiTotal >= 30 & BmiTotal <= 39.9)
            {
                Console.WriteLine("Your BMI is: ");
                Console.WriteLine(BmiTotal);
                Console.WriteLine("You are obease");
            }
            else if (BmiTotal >= 40)
            {
                Console.WriteLine("Your BMI is: ");
                Console.WriteLine(BmiTotal);
                Console.WriteLine("You are morbidly obease");
            }
            else
            {
                Console.WriteLine("?");
            }

            Console.Read();
            return BmiTotal;
        }

    }
}
    

