namespace CsharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

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

            Console.WriteLine($"Biggest Integer: {Number}");
            int OverFlow = Number + 10;
            Console.WriteLine($"Biggest Integer + 10 (No exceptions) = {OverFlow}");

            CheckedMethod(OverFlow, Number);

            string BirthYear = "1997";
            int Year = int.Parse(BirthYear);
            Console.WriteLine($"String to int: {Year}");
            BirthYear = Convert.ToString(Year+2);
            Console.WriteLine($"Int to String: {BirthYear}");

            string Sequence = "12345678911";
            long ALongNumber = long.Parse(Sequence);
            Console.WriteLine($"String to Long: {ALongNumber}");
            Sequence = Convert.ToString(ALongNumber + 2);
            Console.WriteLine($"Long to String: {Sequence}");

            string Pi = "3.14159";
            double PiDouble = double.Parse(Pi);
            Console.WriteLine($"String to Double: {PiDouble}");
            Sequence = Convert.ToString(PiDouble);
            Console.WriteLine($"Double to String: {Sequence}");

            float PiFloat = float.Parse(Pi);
            Console.WriteLine($"String to Float: {PiFloat}");
            Sequence = Convert.ToString(PiFloat);
            Console.WriteLine($"Float to String: {Sequence}");

            string Claim = "True";
            bool isClaim = Convert.ToBoolean(Claim);
            Console.WriteLine($"String to Boolean: {isClaim}");
            Claim = Convert.ToString(isClaim);
            Console.WriteLine($"Double to String: {Claim}");

            int a = 123;
            long b = a;
            Console.WriteLine($"Int to Long implicit conversion");
            b = long.MaxValue;
            a = (int) b;
            Console.WriteLine($"Long to Int explicit conversion (a = {a})");

            char Alpha = 'a';
            int value = Alpha;
            Console.WriteLine($"Char to ASCII int implicit conversion: (Int value = {value})");
            value = (int)Alpha;

            Alpha = (char)value;
            Console.WriteLine($"Int to ASCII Char explicit conversion: (Character: {Alpha})");

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
            Console.WriteLine($"Logical OR: {or}");
            int and = n & m;
            Console.WriteLine($"Logical AND: {and}");
            int xor = n ^ m;
            Console.WriteLine($"Logical XOR: {xor}");

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

            var LeapYear = (Year % 400 == 0) || (Year % 100 != 0 && Year % 4 == 0) ? "It's a leap year" : "Not a leap year";
            Console.WriteLine(LeapYear);
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