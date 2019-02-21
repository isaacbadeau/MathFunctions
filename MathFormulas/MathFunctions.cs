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
            
            bool program = true;
            while (program)
            {
                Console.WriteLine("Welcome to my program! Please make a selection:");
                Console.WriteLine("1. Calculate the circumference and area of a circle.");
                Console.WriteLine("2. Calculate the volume of a hemisphere.");
                Console.WriteLine("3. Calculate the area of a triangle.");
                Console.WriteLine("4. Solve a quadratic equation.");
                Console.WriteLine("5. Quit.");
                string response = Console.ReadLine();
                if (response == "1")
                    CircleAreaCircum();
                else if (response == "2")
                    HemisphereVolume();
                else if (response == "3")
                    TriangleArea();
                else if (response == "4")
                    QuadraticEquation();
                else if (response == "5")
                    program = false;
                else
                    Console.WriteLine("I did not understand, please make a valid selection");
            }

        }



        public static void CircleAreaCircum()
        {
            bool resume = true;
            bool circumArea = true;
            while (circumArea)
            {
                try
                {

                    MathFunctions circleArea = new MathFunctions();
                    MathFunctions circleCircum = new MathFunctions();

                    Console.WriteLine("Welcome to my program to calculate the area, and circumference of a circle.");
                    Console.Write("Please enter the radius of the circle in question: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double circum = circleCircum.Circum(radius);
                    double circleA = circleArea.CircleA(radius);
                    
                    Console.WriteLine("The circumference of your circle is: {0}", circum);
                    Console.WriteLine("The area of your circle is: {0}", circleA);
                    
                    Console.Write("Would you like to evaluate another circle? Yes or No? ");
                    string response = Console.ReadLine();
                    if (response == "yes" || response == "Yes" || response == "y" || response == "Y")
                    {
                        circumArea = true;

                    }
                    else if (response == "no" || response == "No" || response == "n" || response == "N")
                    {

                        circumArea = false;
                    }
                   else
                    {
                        Console.WriteLine("You did not enter a valid selection, Good Bye!");
                        circumArea = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter only numbers!");
                }


            }
        }
        public static void HemisphereVolume()
        {
            bool hemisphereVolume = true;
            while (hemisphereVolume)
            {
                try
                {
                    
                    MathFunctions hemisphereV = new MathFunctions();
                    Console.WriteLine("Welcome to my program to calculate the volume of a hemisphere!");
                    Console.Write("Please enter the radius of your hemisphere: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double volume = hemisphereV.HemisV(radius);
                    Console.WriteLine("The volume of your hemisphere is: {0}", volume);
                    Console.Write("Would you like to evaluate another hemisphere? Yes or No? ");
                    string response = Console.ReadLine();
                    if (response == "yes" || response == "Yes" || response == "y" || response == "Y")
                    {
                        hemisphereVolume = true;
                    }
                    else if (response == "no" || response == "No" || response == "n" || response == "N")
                    {
                        hemisphereVolume = false;
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid selection, Good Bye!");
                        hemisphereVolume = false;
                        
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter only numbers!");
                }

            }
        }
        public static void TriangleArea()
        {
            bool triangleArea = true;
            while (triangleArea)
            {
                try
                {
                    MathFunctions triArea = new MathFunctions();
                    MathFunctions triP = new MathFunctions();
                    Console.WriteLine("Welcome to my program to calculate the area of a triangle!");
                    Console.Write("Please enter side one of your triangle: ");
                    double sideOne = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter side two of your triangle: ");
                    double sideTwo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter side three of your triangle: ");
                    double sideThree = Convert.ToDouble(Console.ReadLine());
                    double p = triP.TriP(sideOne, sideTwo, sideThree);
                    double area = triArea.TriA(sideOne, sideTwo, sideThree);
                    Console.WriteLine("The area of your triangle: {0}", area);
                    Console.Write("Would you like to evaluate another triangle? ");
                    string response = Console.ReadLine();
                    if (response == "yes" || response == "Yes" || response == "y" || response == "Y")
                    {
                        triangleArea = true;
                    }
                    else if (response == "no" || response == "No" || response == "n" || response == "N")
                    {
                        triangleArea = false;
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid selection, Good Bye!");
                        triangleArea = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter only numbers!");
                }

            }
        }
        public static void QuadraticEquation()
        {
            bool quadraticEquation = true;
            while (quadraticEquation)
            {
                try
                {
                    MathFunctions plusQuad = new MathFunctions();
                    MathFunctions minusQuad = new MathFunctions();
                    Console.WriteLine("Welcome to my program to calculate a Quadratic Equation");
                    Console.WriteLine("Quadratics are in the form ax^2 + bx + c = 0");
                    Console.Write("Please enter the a value of your quadratic: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter the b value of your quadratic: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter the c value of your quadratic: ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    double plusValue = plusQuad.QuadPlus(a, b, c);
                    double minusValue = minusQuad.QuadMinus(a, b, c);
                    if (double.IsNaN(plusValue))
                        Console.WriteLine("The first x value is not a real number");
                    else
                        Console.WriteLine("The first value for x is: {0}", plusValue);
                    if (double.IsNaN(minusValue))
                        Console.WriteLine("The second x value is not a real number");
                    else
                        Console.WriteLine("The second value of x is: {0}", minusValue);

                    Console.Write("Would you like to evaluate another quadratic? ");
                    string response = Console.ReadLine();
                    if (response == "yes" || response == "Yes" || response == "y" || response == "Y")
                    
                        quadraticEquation = true;
                    
                    else if (response == "no" || response == "No" || response == "n" || response == "N")
                    {
                        quadraticEquation = false;
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid selection, Good Bye!");
                        quadraticEquation = false;
                    }
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
            return Math.Round(2*(Math.PI) * value, 2);
        }
        public double HemisV(double value)
        {
            return Math.Round(((4.0/ 3.0) * Math.PI * Math.Pow(value, 3))/2, 2);
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


    }
}
