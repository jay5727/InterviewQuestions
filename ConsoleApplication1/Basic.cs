using System;
namespace ConsoleApplication1
{
    class Basic
    {
        static void Main(string[] args)
        {
            EvenOddWithoutForLoop(7);
            sumOfFirstNNumbers(10);
            primeNumber(2);
            Console.WriteLine(returnSmallestOfThree(-1, 4, 5));
            printFirst10PallindromeNumber();

        }
        private static void FibonacciSeries()
        {
            string s1 = "man"; int sum = 0;
            int[] x = new int[26];
            int a = -1, b = 1, c = 0;
            for (int i = 0; i <= 25; i++)
            {
                c = a + b;
                a = b;
                b = c;
                x[i] = c;
            }
            for (int i = 0; i < s1.Length; i++)
            {
                //int asciiValue = s1[i];
                sum += x[s1[i] - 97];
            }
            Console.WriteLine(sum);
        }


        private static void fibonacciSeries()
        {

            //0 1 1 2 3 5 8 13 21 34
            //Prints out the first 10 series...! 
            int a = -1, b = 1, c = 0;
            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine("i = " + i + " c = " + c);
            }
        }

        private static void primeNumber(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
                Console.Write(n);
            else
                Console.Write(n + " is not a prime number...!");
        }

        private static int returnMaxOfThree(int a, int b, int c)
        {
            return (a > b ? (a > c ? a : c) : (b > c ? b : c));
        }

        private static int returnSmallestOfThree(int a, int b, int c)
        {
            return (a < b ? (a < c ? a : c) : (b < c ? b : c));
        }

        private static void main1()
        {
            for (int i = 1; i <= 100; i++)
            {
                int r, sum = 0, temp;

                int n = i;//It is the number variable to be checked for palindrome  

                temp = n;
                while (n > 0)
                {
                    r = n % 10;  //getting remainder  
                    sum = (sum * 10) + r;
                    n = n / 10;
                }
                if (temp == sum)
                    Console.WriteLine(temp + "palindrome number ");
                //else
                //  Console.WriteLine("not palindrome");
            }
        }


        private static void printFirst10PallindromeNumber()
        {
            int n, b, rev = 0;
            int limit = 50;

            for (int i = 1; i <= limit; i++)
            {
                n = i;
                while (n > 0)
                {
                    b = n % 10;
                    rev = rev * 10 + b;
                    n = n / 10;
                }
                if (rev == i)
                {
                    Console.WriteLine(i + " ");
                }
                rev = 0;
            }
        }

        private static void sumOfFirstNNumbers(int n)
        {
            int sum = 0;
            //1
            for (int i = n; i > 0; i--)
            {
                sum += i;
            }
            //2
            //while (n > 0)
            //{
            //    sum += n;
            //    n--;
            //}
            Console.WriteLine(sum);
        }

        private static void EvenOddWithoutForLoop(int v)
        {
            //v will always have value -1 or 0 depending whether it is odd or even...!!!
            while (v > 0)
            {
                v = v - 2;
            }
            Console.WriteLine(v + "<---");
            Console.WriteLine(v == 0 ? "Even" : "Odd");
        }

        private static void PrintFizzBuzz()
        {
            int i;
            for (i = 1; i <= 100; i++)
            {
                // number divisible by 3 and 5 will
                // always be divisible by 15, print 
                // 'FizzBuzz' in place of the number
                if (i % 15 == 0)
                    Console.WriteLine("FizzBuzz\t");

                // number divisible by 3? print 'Fizz'
                // in place of the number
                else if ((i % 3) == 0)
                    Console.WriteLine("Fizz\t");

                // number divisible by 5, print 'Buzz'  
                // in place of the number
                else if ((i % 5) == 0)
                    Console.WriteLine("Buzz\t");

                else // print the number            
                    Console.WriteLine(i);

            }
        }

        private int returnSumOfAllEvenNosInArray()
        {
            int sum = 0;
            int[] x = new int[] { 10, 11, 7, 60, 3, 5, 3, 4, 8 };
            for (int i = 0; i < x.Length; i++)
            {
                //sum += (i % 2 != 0) ? x[i ] : 0;
                sum += (x[i] > 0 && x[i] % 2 == 0) ? x[i] : 0;
            }
            return sum;
        }

        //A destination is located at point x(x >0) of the coordinate line.
        //In one step the robot can move 1,2,3,4 or 5 positions forward.
        //Determine, what is the minimum number of steps the robot 
        //need to make in order to get his destination.
        //Sample i/p :5  o/p:1
        //Sample i/p :12 o/p:3 
    }
}