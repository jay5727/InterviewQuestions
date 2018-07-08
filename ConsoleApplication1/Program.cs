using System;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            findIntOccurence();
            int x = 97825;
            string s = x.ToString();
            if (!string.IsNullOrEmpty(s))
            {
                string temp = "";
                for (int i = 1; i <= s.Length; i++)
                {
                    if ((i % 2 == 0))
                        temp += "0";

                    else
                        temp += (s[i - 1]);
                    //temp += (i % 2 == 0) ? "0" : (s[i-1] + "");
                }
                Console.WriteLine(temp);
            }

            int sum = 0;
            for (int i = 0, j = 0; i < 5 & j < 5; ++i, j = i + 1)
            {
                sum += i;
            }
            //Console.WriteLine(sum);
            int sum1 = 0;

            //for (int i = 0; i < 5; ++i)
            //{
            //    for (int j = 0; j < 5; j = i + 1)
            //    {
            //        sum1 += i;
            //    }
            //}
            //Console.WriteLine(sum1);
        }

        private static void findIntOccurence()
        {
            //48-57...(0-9)
            bool[] char_set = new bool[58];//0-57
            int[] x = { 0, 1, 2, 2, 3, 3, 3, 4, 5, 6 };
            for (int i = 0; i < x.Length; i++)
            {
                int val = x[i] + 48;
                if (!char_set[val])
                {
                    char_set[val] = true;
                    Console.Write(x[i]);
                }
            }
        }
    }
}