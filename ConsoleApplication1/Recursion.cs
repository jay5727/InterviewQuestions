using System;
namespace ConsoleApplication1
{
    class Recursion
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Recursion().digitToBinary(49)));
            displayNumberWithoutForLoop(1);
        }

        //2^0 = 1//0
        //2^1 = 2//10
        //2^2 = 4//100
        //2^3 = 8//1000
        //2^4 = 16//10000
        //2^5 = 32//100000
        string val = "";
        private string digitToBinary(int digit)
        {
            if (digit <= 0) return "0";
            val += (digit % 2 == 0) ? "0" : "1";
            digitToBinary(digit / 2);
            return Strings.ReverseGivenString(val);
        }

        //private String digitToBinary(int digit)
        //{
        //    String val = "";
        //    if (digit == 0) return "1";
        //    if (digit % 2 == 0)
        //    {
        //        val += "1";
        //        digitToBinary(digit / 2);
        //    }
        //    else
        //    {
        //        val += "0";
        //    }
        //    System.out.println(val);
        //}

        private static void displayNumberWithoutForLoop(int n)
        {
            if (n <= 10)
            {
                Console.WriteLine(n);
                //giving a recursive call to the same method itself...
                displayNumberWithoutForLoop(n + 1);
            }
        }
    }
}
