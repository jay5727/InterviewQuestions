using System;
namespace ConsoleApplication1
{
    public class Strings
    {
        static void Main(string[] args)
        {

            if (checkIfUserEnteredNumber("1234A"))
            {
                Console.WriteLine("Number It is");
            }
            else
            {
                Console.WriteLine("Not a Number");
            }
            reverseWordsInAString("ABC");

            //Console.WriteLine(ConvertToUpperCase("Jay"));

            //if (findFirstStringOccurence("JAY"))
            //{
            //     Console.WriteLine("UNIQUE");
            //}
            //else
            // Console.WriteLine("DUPLICATES");

            Console.WriteLine(findFirstStringOccurence("AJAY"));

        }

        //My Name is jay
        //yM emaN is yaj
        public static string ReverseGivenString(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                string rev = "";
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    rev += s[i];
                }
                return rev;
            }
            return null;
        }

        private static void reverseWordsInAString(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                string temp = "";
                string[] arr = s.Split(' ');
                if (arr.Length > 0)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        temp +=
                            (i < arr.Length - 1) ? ReverseGivenString(arr[i]) + " "
                            : ReverseGivenString(arr[i]);

                        //if (i < arr.Length - 1)
                        //{
                        //    temp += ReverseGivenString(arr[i]) + " ";
                        //}
                        //else
                        //{
                        //    //not to get space after last letter/alpahabet...!
                        //    temp += ReverseGivenString(arr[i]);
                        //}
                    }
                    Console.WriteLine(temp);
                }
            }
        }

        //String reverse without reversing the words
        //i/p : (My Name is Jay) o/p : (Jay is Name My)
        private static void StringReverseWithoutWordsReverse()
        {
            string s = "My Name is Jay";
            string temp = "";
            string[] arr = s.Split(' ');
            if (arr.Length > 0)
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    //temp += arr[i]+" ";
                    temp += (i != 0) ? (arr[i]) + " " : (arr[i]);
                }
                Console.WriteLine(temp);
            }
        }

        private static bool checkIfUserEnteredNumber(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                int count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    int ascii = s[i];
                    if (s[i] >= 48 && s[i] <= 57)
                    {
                        count++;
                    }
                }
                return (s.Length == count);
            }
            return false;
        }
        private static string ConvertToUpperCase(string userString)
        {
            string temp = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                int x = s[i] >= 97 ?s [i]-32 : s[i];
                char character = (char)x;
                temp += character.ToString();
            }
            return temp;
        }

        private static string findFirstStringOccurence(string s1)
        {
            bool[] char_set = new bool[26];

            for (int i = 0; i < s1.Length; i++)
            {
                int val = s1.ToUpper()[i] - 65;
                if (char_set[val])
                {
                    return s1[i].ToString();
                }
                char_set[val] = true;
            }
            return "No Duplicates Found";
        }
    }
}
