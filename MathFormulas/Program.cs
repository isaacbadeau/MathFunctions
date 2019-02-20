using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
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



        static void CircleAreaCircum()
        {
            bool circumArea = true;
            while (circumArea)
            {
                try
                {
                    Console.WriteLine("Welcome to my program to calculate the area, and circumference of a circle.");
                    Console.Write("Please enter the radius of the circle in question: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double circum = Math.Round((2 * Math.PI * radius),2);
                    double area = Math.Round(((Math.PI) * Math.Pow(radius, 2)), 2);
                    Console.WriteLine("The circumference of your circle is: {0}", circum);
                    Console.WriteLine("The area of your circle is: {0}", area);
                    Console.Write("Would you like to evaluate another circle? ");
                    string response = Console.ReadLine();
                    if (response == "yes" || response == "Yes" || response == "y" || response == "Y")
                    {
                        circumArea = true;
                    }
                    else if (response == "no" || response == "No" || response == "n" || response == "N")
                    {
                        circumArea = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter only numbers!");
                }


            }
        }
        static void HemisphereVolume()
        {
            bool hemisphereVolume = true;
            while (hemisphereVolume)
            {
                try
                {
                    Console.WriteLine("Welcome to my program to calculate the volume of a hemisphere!");
                    Console.Write("Please enter the radius of your hemisphere: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double volume = Math.Round((4 / 3) * Math.PI * Math.Pow(radius, 3) / 2, 2);
                    Console.WriteLine("The volume of your hemisphere is: {0}", volume);
                    Console.Write("Would you like to evaluate another hemisphere? ");
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
                        Console.WriteLine("I did not understand.");
                        Console.WriteLine("Would you like to evalute another hemisphere?");
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter only numbers!");
                }

            }
        }
        static void TriangleArea()
        {
            bool triangleArea = true;
            while (triangleArea)
            {
                try
                {
                    Console.WriteLine("Welcome to my program to calculate the area of a triangle!");
                    Console.Write("Please enter side one of your triangle: ");
                    double sideOne = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter side two of your triangle: ");
                    double sideTwo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter side three of your triangle: ");
                    double sideThree = Convert.ToDouble(Console.ReadLine());
                    double p = (sideOne + sideTwo + sideThree) / 2;
                    double area = Math.Round((Math.Sqrt(p * (p - sideOne) * (p - sideTwo) * (p - sideThree))),2);
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
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter only numbers!");
                }

            }
        }
        static void QuadraticEquation()
        {
            bool quadraticEquation = true;
            while (quadraticEquation)
            {
                try
                {
                    Console.WriteLine("Welcome to my program to calculate a Quadratic");
                    Console.WriteLine("Quadratics are in the form ax^2 + bx + c = 0");
                    Console.Write("Please enter the a value of your quadratic: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter the b value of your quadratic: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Please enter the c value of your quadratic: ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    double plusValue = Math.Round(((-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a)),2);
                    double minusValue = Math.Round(((-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a)),2);
                    
                    Console.WriteLine("The first value of your quadratic is: {0}", plusValue);
                    Console.WriteLine("The second value of your quadratic is: {0}", minusValue);
                    Console.Write("Would you like to evaluate another quadratic? ");
                    string response = Console.ReadLine();
                    if (response == "yes" || response == "Yes" || response == "y" || response == "Y")
                    {
                        quadraticEquation = true;
                    }
                    else if (response == "no" || response == "No" || response == "n" || response == "N")
                    {
                        quadraticEquation = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter only numbers!");
                }

            }
        }


    }
}
