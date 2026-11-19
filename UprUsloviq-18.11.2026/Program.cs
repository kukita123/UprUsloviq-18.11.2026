namespace UprUsloviq_18._11._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Qadratic Equation Solver
            Console.WriteLine("Quadratic equation. Please, enter the coefficients a, b, and c: ");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            if(a == 0) //linear equation
            {
                Console.WriteLine("\nThis is a linear equation.");
                if(b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("The equation has infinitely many solutions.");
                    }
                    else
                    {
                        Console.WriteLine("The equation has no solution.");
                    }
                }
                else
                {
                    double root = -c / b;
                    Console.WriteLine($"The solution is x = {root}");
                }
            }
            else  //quadratic equation
            {
                double d = Math.Pow(b, 2) - 4 * a * c;

                if (d > 0)
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine($"\nThe equation has two distinct real roots: x1 = {x1}, x2 = {x2}");
                }
                else if (d == 0)
                {
                    double root = -b / (2 * a);
                    Console.WriteLine($"\nThe equation has one real root: x = {root}");
                }
                else
                {
                    Console.WriteLine("\nThe equation has no real roots.");
                }
            }
            #endregion

            #region Days in Month
            int month, year;
            Console.Write("\nEnter the month (1-12):");
            month = int.Parse(Console.ReadLine());
            Console.Write("Enter the year:");
            year = int.Parse(Console.ReadLine());

            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            if(month == 2)
            {
                if (isLeapYear)
                {
                    Console.WriteLine($"February {year} has 29 days.");
                }
                else
                {
                    Console.WriteLine($"February {year} has 28 days.");
                }
            }
            else 
            {
                switch(month)
                {
                    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                        Console.WriteLine($"Month {month} has 31 days.");
                        break;
                    case 4: case 6: case 9: case 11:
                        Console.WriteLine($"Month {month} has 30 days.");
                        break;
                    default:
                        Console.WriteLine("Invalid month entered.");
                        break;
                }
            }
            #endregion

            #region maximum of three numbers
            Console.WriteLine("\nEnter three numbers to find the maximum:");
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double num3 = double.Parse(Console.ReadLine());

           if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"The maximum number is: {num1}");
            }
            else if (num2 > num3)
            {
                Console.WriteLine($"The maximum number is: {num2}");
            }
            else
            {
                Console.WriteLine($"The maximum number is: {num3}");
            }
            #endregion

            #region function of two variables
            Console.WriteLine("\nEnter two numbers:");
            int x, y;
            Console.Write("x = ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            y = int.Parse(Console.ReadLine());
            int f;
            if (x < 0)
            {
                if (x > y)
                    f = x;
                else
                    f = y;
            }
            else
            {
                if(x < y)
                    f = x;
                else
                    f = y;
            }
            Console.WriteLine($"The value of the function f(x, y) is: {f}");
            #endregion

            #region Roman Numeral Converter
            //enter number between 1 and 89. Write a program that converts
            //the number to Roman numerals.
            int number;
            Console.WriteLine("\nEnter a number between 1 and 89 to convert to Roman numerals:");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("The Roman numeral is:");
            if(number >= 40 && number <= 50)
            {
                Console.Write("XL");
                number -= 40;
            }
            else
            {
                if (number >= 50 && number <= 89)
                {
                    Console.Write("L");
                    number -= 50;
                }
            }
            switch (number / 10)
            {
                case 1:
                    Console.Write("X");
                    break;
                case 2:
                    Console.Write("XX");
                    break;
                case 3:
                    Console.Write("XXX");
                    break;
            }
            switch(number % 10)
            {
                case 1:
                    Console.Write("I");
                    break;
                case 2:
                    Console.Write("II");
                    break;
                case 3:
                    Console.Write("III");
                    break;
                case 4:
                    Console.Write("IV");
                    break;
                case 5:
                    Console.Write("V");
                    break;
                case 6:
                    Console.Write("VI");
                    break;
                case 7:
                    Console.Write("VII");
                    break;
                case 8:
                    Console.Write("VIII");
                    break;
                case 9:
                    Console.Write("IX");
                    break;
            }
            #endregion
        }
    }
}
