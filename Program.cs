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
            string Sequence = "I am the Author";
            Console.WriteLine($"Printing an string: {Sequence}");

            Console.WriteLine($"Biggest Integer: {Number}");
            int OverFlow = Number + 10;
            Console.WriteLine($"Biggest Integer + 10 (No exceptions) = {OverFlow}");

            CheckedMethod(OverFlow, Number);
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