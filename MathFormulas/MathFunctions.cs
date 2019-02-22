using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathFunctions;



namespace MathFunctions
{
    public class MathFunctions
    {

        public static void Main(string[] args)
        {
            MathFunctions function = new MathFunctions();
            bool program = true;
            while (program)
            {
                function.MainMenu();
                string response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        function.CircleAreaCircum();
                        break;
                    case "2":
                        function.HemisphereVolume();
                        break;
                    case "3":
                        function.TriangleArea();
                        break;
                    case "4":
                        function.QuadraticEquation();
                        break;
                    case "5":
                        program = false;
                        break;
                    default:
                        Console.WriteLine("Invalid selction.");
                        break;
                }
            }
        }

        public void CircleAreaCircum()
        {
            MathFunctions function = new MathFunctions();
            bool circumArea = true;
            while (circumArea)
            {
                try
                {
                    function.CircleValues();
                    circumArea = function.ResponseYesNo();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter only numbers!");
                }
            }
        }
        public void HemisphereVolume()
        {
            MathFunctions function = new MathFunctions();
            bool hemisphereVolume = true;
            while (hemisphereVolume)
            {
                try
                {
                    function.HemiValues();
                    hemisphereVolume = function.ResponseYesNo();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter only numbers!");
                }
            }
        }
        public void TriangleArea()
        {
            MathFunctions function = new MathFunctions();
            bool triangleArea = true;
            while (triangleArea)
            {
                try
                {
                    function.TriangleValues();
                    triangleArea = function.ResponseYesNo();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter only numbers!");
                }
            }
        }
        public void QuadraticEquation()
        {
            
            MathFunctions function = new MathFunctions();
            bool quadraticEquation = true;
            while (quadraticEquation)
            {
                try
                {
                    function.QuadValues();
                    quadraticEquation = function.ResponseYesNo();

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter only numbers!");
                }

            }
        }
        public double CircleA(double value)
        {
            return Math.Round(((Math.PI) * Math.Pow(value, 2)), 2);
        }
        public double Circum(double value)
        {
            return Math.Round(2 * (Math.PI) * value, 2);
        }
        public double HemisV(double value)
        {
            return Math.Round(((4.0 / 3.0) * Math.PI * Math.Pow(value, 3)) / 2, 2);
        }
        public double TriP(double value1, double value2, double value3)
        {
            return (value1 + value2 + value3) / 2;
        }
        public double TriA(double value1, double value2, double value3)
        {
            MathFunctions triP = new MathFunctions();
            double p = triP.TriP(value1, value2, value3);
            return Math.Round((Math.Sqrt(p * (p - value1) * (p - value2) * (p - value3))), 2);
        }
        public double QuadPlus(double value1, double value2, double value3)
        {
            return Math.Round(((-value2 + Math.Sqrt(Math.Pow(value2, 2) - (4 * value1 * value3))) / (2 * value1)), 2);
        }
        public double QuadMinus(double value1, double value2, double value3)
        {
            return Math.Round(((-value2 - Math.Sqrt(Math.Pow(value2, 2) - (4 * value1 * value3))) / (2 * value1)), 2);
        }
        public bool ResponseYesNo()
        {
            while (true)
            {
                Console.Write("Would you like to do another? ");
                string response = Console.ReadLine();
                switch(response.ToLower())
                {
                    case "yes":
                        return true;
                    case "no":
                        return false;
                    default:
                        Console.WriteLine("Invalid Entry.");
                        break;
                } 
            }
        }
        public void MainMenu()
        {
            Console.WriteLine("Please make a selection:");
            Console.WriteLine("1. Calculate the circumference and area of a circle.");
            Console.WriteLine("2. Calculate the volume of a hemisphere.");
            Console.WriteLine("3. Calculate the area of a triangle.");
            Console.WriteLine("4. Solve a quadratic equation.");
            Console.WriteLine("5. Quit.");
        }
        public void QuadValues()
        {
            MathFunctions function = new MathFunctions();
            Console.WriteLine("Calculate a Quadratic Equation.");
            Console.WriteLine("Quadratics are in the form ax^2 + bx + c = 0");
            Console.Write("Please enter the a value of your quadratic: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the b value of your quadratic: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the c value of your quadratic: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double plusValue = function.QuadPlus(a, b, c);
            double minusValue = function.QuadMinus(a, b, c);
            if (double.IsNaN(plusValue))
                Console.WriteLine("The first x value is not a real number");
            else
                Console.WriteLine("The first value for x is: {0}", plusValue);
            if (double.IsNaN(minusValue))
                Console.WriteLine("The second x value is not a real number");
            else
                Console.WriteLine("The second value of x is: {0}", minusValue);
        }
        public void TriangleValues()
        {
            MathFunctions function = new MathFunctions();
            Console.WriteLine("Calculate the area of a triangle.");
            Console.Write("Please enter side one of your triangle: ");
            double sideOne = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter side two of your triangle: ");
            double sideTwo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter side three of your triangle: ");
            double sideThree = Convert.ToDouble(Console.ReadLine());
            double p = function.TriP(sideOne, sideTwo, sideThree);
            double area = function.TriA(sideOne, sideTwo, sideThree);
            Console.WriteLine("The area of your triangle: {0}", area);
        }
        public void HemiValues()
        {
            MathFunctions function = new MathFunctions();
            Console.WriteLine("Calculate the volume of a hemisphere.");
            Console.Write("Please enter the radius of your hemisphere: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double volume = function.HemisV(radius);
            Console.WriteLine("The volume of your hemisphere is: {0}", volume);
        }
        public void CircleValues()
        {
            MathFunctions function = new MathFunctions();
            Console.WriteLine("Calculate the area, and circumference of a circle.");
            Console.Write("Please enter the radius of the circle in question: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circum = function.Circum(radius);
            double circleA = function.CircleA(radius);
            Console.WriteLine("The circumference of your circle is: {0}", circum);
            Console.WriteLine("The area of your circle is: {0}", circleA);
        }
            
            
    }
}
