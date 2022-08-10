/*
	This is a C# Basic syntex assignment.
	This program has total 11 tasks.
*/

namespace CsharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 (Printing Hello World)
            Console.WriteLine("Hello, World!");
            #endregion

            #region Task 2 (Declaring & Printing primitive types)
            bool isIt = true;
            Console.WriteLine($"Printing bool value: {isIt}");
            int Number = int.MaxValue;
            Console.WriteLine($"Printing maximum integer data: {Number}");
            long BigNumber = long.MaxValue;
            Console.WriteLine($"Printing maximum long data: {BigNumber}");
            decimal DecimalNumber = decimal.MaxValue;
            Console.WriteLine($"Printing maximum decimal data: {DecimalNumber}");
            float Fraction = float.MaxValue;
            Console.WriteLine($"Printing maximum float data: {Fraction}");
            double BigFraction = double.MaxValue;
            Console.WriteLine($"Printing maximum double data: {BigFraction}");
            char Symbol = 'C';
            Console.WriteLine($"Printing a character: {Symbol}");
            string Sentence = "I am the Author";
            Console.WriteLine($"Printing an string: {Sentence}");
            #endregion

            #region Task 3 (Overflow exception with checked keyword)
            Console.WriteLine($"Biggest Integer: {Number}");
            int OverFlow = Number + 10;
            Console.WriteLine($"Biggest Integer + 10 (No exceptions) = {OverFlow}");

            CheckedMethod(OverFlow, Number);
            #endregion

            #region Task 4 (Type Conversions)
            // String to Int (and vice-versa) implicit conversion not possible 
            string BirthYear = "1997";
            int Year = int.Parse(BirthYear);
            Console.WriteLine($"String to int: {Year}");
            BirthYear = Convert.ToString(Year+2);
            Console.WriteLine($"Int to String: {BirthYear}");

            // String to Long (and vice-versa) implicit conversion not possible 
            string Sequence = "12345678911";
            long ALongNumber = long.Parse(Sequence);
            Console.WriteLine($"String to Long: {ALongNumber}");
            Sequence = Convert.ToString(ALongNumber + 2);
            Console.WriteLine($"Long to String: {Sequence}");

            // String to Double (and vice-versa) implicit conversion not possible 
            string Pi = "3.14159";
            double PiDouble = double.Parse(Pi);
            Console.WriteLine($"String to Double: {PiDouble}");
            Sequence = Convert.ToString(PiDouble);
            Console.WriteLine($"Double to String: {Sequence}");

            // String to Float (and vice-versa) implicit conversion not possible 
            float PiFloat = float.Parse(Pi);
            Console.WriteLine($"String to Float: {PiFloat}");
            Sequence = Convert.ToString(PiFloat);
            Console.WriteLine($"Float to String: {Sequence}");

            // String to Boolean (and vice-versa) implicit conversion not possible 
            string Claim = "True";
            bool isClaim = Convert.ToBoolean(Claim);
            Console.WriteLine($"String to Boolean: {isClaim}");
            Claim = Convert.ToString(isClaim);
            Console.WriteLine($"Double to String: {Claim}");

            // Int to Long implicit conversion 
            int a = 123;
            long b = a;
            Console.WriteLine($"Int to Long implicit conversion");

            //Long to Int implicit conversion not possible, only explicit conversion
            b = long.MaxValue;
            a = (int) b;
            Console.WriteLine($"Long to Int explicit conversion (a = {a})");

            //Char to ASCII int implicit conversion
            char Alpha = 'a';
            int value = Alpha;
            Console.WriteLine($"Char to ASCII int implicit conversion: (Int value = {value})");

            //ASCII int to Char, only explicit conversion possible
            value = (int)Alpha;

            Alpha = (char)value;
            Console.WriteLine($"Int to ASCII Char explicit conversion: (Character: {Alpha})");
            #endregion

            #region Task 5 (Logic & Math Operations)
            double math = 130;
            double added = math + 17;
            Console.WriteLine($"Sum: {added}");
            double sub = added - 23;
            Console.WriteLine($"Subtraction: {sub}");
            double mul = added * sub;
            Console.WriteLine($"Multiplication: {mul}");
            double div = mul / math;
            Console.WriteLine($"Division: {div}");
            double remainder = math % sub;
            Console.WriteLine($"Remainder: {remainder}");

            int n = 1, m = 1;
            int or = n | m;
            Console.WriteLine($"Bitwise OR: {or}");
            int and = n & m;
            Console.WriteLine($"Bitwise AND: {and}");
            int xor = n ^ m;
            Console.WriteLine($"Bitwise XOR: {xor}");
            #endregion

            #region Task 6 & 7 (If, else if, else with logical operators)
            Year = 1997;
            if(Year % 400 == 0)
            {
                Console.WriteLine($"Year {Year} is a leap year.");
            }
            else if(Year % 100 != 0 && Year % 4 == 0)
            {
                Console.WriteLine($"Year {Year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"Year {Year} is not a leap year.");
            }
            #endregion

            #region Task 8 (Ternary Operator)
            // Replacement of above if else codes with ternary operator
            var LeapYear = (Year % 400 == 0) || (Year % 100 != 0 && Year % 4 == 0) ? "It's a leap year" : "Not a leap year";
            Console.WriteLine(LeapYear);
            #endregion

            #region Task 9 (Various Comment types)
            /*
                This task was done by commenting
                and diving into regions the whole code.
            */
            #endregion

            #region Task 9 (Loops)
            for(var i = 1; i <= 100; i++)
            {
                if(i == 95)
                {
                    continue;
                }
                else if(i==99)
                {
                    break;
                }
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            var k = 1;
            while(k <= 100)
            {
                if (k == 95)
                {
                    k++;
                    continue;
                }
                else if (k == 99)
                {
                    break;
                }
                Console.Write($"{k} ");
                k++;
            }
            Console.WriteLine();

            k = 1;
            do
            {
                if (k == 95)
                {
                    k++;
                    continue;
                }
                else if (k == 99)
                {
                    break;
                }
                Console.Write($"{k} ");
                k++;
            } while (k <= 100);
            Console.WriteLine();

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "Mercedes" };
            foreach(var car in cars)
            {
                Console.WriteLine(car);
            }
            #endregion
        }

        static void CheckedMethod(int OverFlow, int Number)
        {
            try
            {
                OverFlow = checked(Number + 10);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
            }
        }
    }
}