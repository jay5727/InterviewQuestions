using System;

namespace ConsoleApplication1
{
    class Patterns
    {
        static void Main(string[] args)
        {
            //Triang();
            //Triangle();
            print3(4);
            print4();
            print5();
            print6();
            print7(5);
            //TriangleSunday();
            //myProgram();
            //myProgramM(7);

        }

        static void Triang()
        {
            //1
            //21
            //123
            //4321
            //12345
            int size = 5;
            for (int i = 1; i <= size; i++)
            {
                bool isEven = (i % 2 == 0);
                for (int j = isEven ? i : 1; isEven ? (j >= 1) : (j <= i); j = isEven ? (j -= 1) : (j += 1))
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        private static void Triangle()
        {
            int length = 4;
            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % i == 0)
                        Console.Write("0");
                    else
                        Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        private static void print3(int length)
        {
            //length=4;
            /*

            *
            # *
            * # *
            # * # *

            */
            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    bool isRowEven = (i % 2 == 0);
                    bool isColEven = (j % 2 == 0);
                    Console.Write(isRowEven ? isColEven ? "*" : "#" : !isColEven ? "*" : "#");

                    //if (isRowEven)
                    //{
                    //    Console.Write(isColEven ? "*" : "#");

                    //}
                    //else
                    //{
                    //    Console.Write(isColEven ? "#" : "*");
                    //}
                }
                Console.WriteLine();

            }
        }

        private static void print4()
        {
            //12345
            //4321
            //123
            //21
            //1
            int size = 5;
            for (int i = size; i >= 1; i--)
            {
                bool isEven = (i % 2 == 0);
                for (int j = isEven ? i : 1; isEven ? (j >= 1) : (j <= i); j = isEven ? (--j) : (++j))
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        private static void print5()
        {
            //1
            //24
            //135
            //2468
            //13579
            int size = 5;
            int canBeEvenOdd = 1;
            for (int i = 1; i <= size; i++)
            {
                bool isRowEven = i % 2 == 0;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(canBeEvenOdd);
                    canBeEvenOdd += 2;

                }
                //purposely negating isRowEven for next Iteration
                canBeEvenOdd = !isRowEven ? 2 : 1;
                Console.WriteLine();
            }
        }

        private static void print6()
        {
            //13579
            //3579
            //579
            //79
            //9
            int size = 5;
            for (int i = 1; i <= (size * 2) - 1; i += 2)
            {
                for (int j = i; j <= (size * 2) - 1; j += 2)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        private static void print7(int n)
        {
            int row = n;
            int length = ((2 * row) - 1);
            for (int i = 1; i <= length; i += 2)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write(i);
                Console.WriteLine();
            }
        }

        private static void TriangleSunday()
        {
            int length = 100;
            //int count = 0;
            //bool isEven = false;
            //int inc = 2;
            //for (int i = 1; i <= length; i += 1)
            //{
            //    count++;
            //    Console.Write(i + " ");
            //    if (count == 5)
            //    {
            //        inc = 1;
            //        isEven = !isEven;
            //        count = 0; Console.WriteLine();
            //    }
            //}
            //1
            //24
            //135
            //2468
            //13579
            int num = 1;
            int size = 5;
            int canBeEvenOdd = 1;
            for (int i = 1; i <= 10; i++)
            {
                bool isRowEven = i % 2 == 0;
                for (int j = 1; j <= size; j++)
                {
                    Console.Write(canBeEvenOdd + "  ");
                    canBeEvenOdd += 2;

                }
                //purposely negating isRowEven for next Iteration
                //canBeEvenOdd = !isRowEven ? canBeEvenOdd +1 : canBeEvenOdd -1;
            }

        }

        static void OnAddysDemand()
        {
            int num = 3;
            int size = num * 2;
            int start = 1;
            for (int i = 1; i < size; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.Write(i <= num && j == start ? "*" :
                                  i == num ? "*" :
                                  i >= num && j == num ? "*" : " ");
                    //if (i <= num && j == start)
                    //    Console.Write("*");
                    //else if(i==num)
                    //    Console.Write("*");
                    //else if(i >= num && j == num)
                    //    Console.Write("*");
                    //else
                    //    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void myProgram()
        {
            int size = 7;//size should be always odd!!!
            if (size % 2 == 1 && size >= 3)
            {
                for (int i = 1; i <= size; i++)
                {
                    for (int j = 1; j <= size; j++)
                    {
                        int x = (size / 2) + 1;
                        //just when intersection is met xD.
                        if (i == x && j == x) Console.Write("+ ");
                        else
                        {
                            if (i == x) Console.Write("- ");//middle row
                            if (j == x) Console.Write("| ");//middle column
                            if (i <= x - 1)//TOP right
                            {
                                if (j >= x + 1)//if (j == 5 || j == 6 || j == 7)
                                    Console.Write("* ");
                                else if (j <= x - 1)//if (j == 1 || j == 2 || j == 3)
                                    Console.Write("  ");
                            }
                            if (i >= x + 1)//BOTTOM left
                            {
                                if (j <= x - 1)//if (j == 1 || j == 2 || j == 3)
                                    Console.Write("* ");
                                else if (j >= x + 1) //if(j == 5 || j == 6 || j == 7)
                                    Console.Write("  ");
                            }
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Sorry Triangle Can't be populated");
            }
        }

        private static void myProgramM(int n)
        {
            int size = n / 2;
            for (int i = 0; i < (n); i++)
            {
                char firstChar = i < size ? ' ' : (i == size) ? '-' : '#';
                char lastChar = i < size ? '*' : (i == size) ? '-' : ' ';

                for (int j = 0; j < (n); j++)
                {
                    char middleChar = (i == j) ? '+' : '|';
                    char c = (j < size) ? firstChar : (j == size) ? middleChar : lastChar;
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
        }
    }
}