using System;

namespace Algorhitms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckNumbers(11, 21));
            Console.WriteLine(CheckNumbers(11, 20));
            Console.WriteLine(CheckNumbers(10, 10));

            Console.WriteLine(CheckSumLength(4, 5));
            Console.WriteLine(CheckSumLength(7, 4));
            Console.WriteLine(CheckSumLength(10, 10));

            Console.WriteLine(SumRules(4, 5, 7));
            Console.WriteLine(SumRules(7, 4, 12));

            Console.WriteLine(CheckThirteen(4, 5));
            Console.WriteLine(CheckThirteen(7, 12));
            Console.WriteLine(CheckThirteen(10, 13));
            Console.WriteLine(CheckThirteen(17, 33));

            Console.WriteLine(CheckDifference(4, 5, 6));
            Console.WriteLine(CheckDifference(-1, 0, 1));

            Console.WriteLine(InsertString("[[]]", "Hello"));

            Console.WriteLine(MakeStringYP("abcab"));
            Console.WriteLine(MakeStringYP("python"));

            Console.WriteLine(MakeStringAA("abcab"));
            Console.WriteLine(MakeStringAA("python"));
            Console.WriteLine(MakeStringAA("aacda"));

            Console.WriteLine(CheckArray(new[] {10, 20, 30, 40, 50 }));
            Console.WriteLine(CheckArray(new[] { 10, 20, 40, 10 }));
            Console.WriteLine(CheckArray(new[] { 20, 40, 50, 60, 70 }));

            Console.WriteLine(CheckTwoArrays(new[] { 10, 20, 40, 50 }, new[] { 10, 20, 40, 50 }));
            Console.WriteLine(CheckTwoArrays(new[] { 10, 20, 40, 50 }, new[] { 1, 20, 40, 5 }));


            Console.WriteLine(ArraySum(new[] { 10, 20, 30, 40, 50 }));

            Console.WriteLine("Reversed array: " + ReverseArrayToString(new[] { 10, 20, -30, -40 }));

            Console.WriteLine(CheckArrayDoubles(new int[] {10, 10 }));
            Console.WriteLine(CheckArrayDoubles(new int[] { 20, 20 }));
            Console.WriteLine(CheckArrayDoubles(new int[] { 20, 10 }));
            Console.WriteLine(CheckArrayDoubles(new int[] { 5, 11 }));
        }

        private static int CheckNumbers(int a, int b)
        {
            //No 52.
            //Write a C# Sharp program to find the larger from two given integers.
            //However if the two integers have the same remainder when divided by 7,
            //then the return the smaller integer. If the two integers are the same, return 0.

            if (a == b)
            {
                return 0;
            }
            else if (a % 7 == b % 7)
            {
                return a > b ? b : a;
            }
            else
            {
                return a > b ? a : b;
            }

            //one line try out
            //return a == b ?
            //0 :
            //a % 7 == b % 7 ?
            //a > b ?
            //b :
            //a : a > b ?
            //a :
            //b;
        }

        private static int CheckSumLength(int a, int b)
        {
            //No. 54
            //Write a C# Sharp program to compute the sum of two given non-negative integers x and y
            //as long as the sum has the same number of digits as x.
            //If the sum has more digits than x then return x without y.
            int c = a + b;

            return c.ToString().Length == a.ToString().Length ? c : a;
        }

        private static int SumRules(int a, int b, int c)
        {
            //No. 57
            //Write a C# Sharp program to compute the sum of the three given integers.
            //However, if any of the values is in the range 10..20 inclusive then that value counts as 0, except 13 and 17.
            return SumRulesHelperMethod(a) + SumRulesHelperMethod(b) + SumRulesHelperMethod(c);
        }
        private static int SumRulesHelperMethod(int x)
        {
            //return x < 10 || x > 20 || x == 13 || x == 17 ? x : 0;

            return x > 9 && x < 13 || x > 13 && x < 17 || x > 18 && x < 21 ? 0 : x;
        }

        private static int CheckThirteen(int a, int b)
        {
            //No. 58
            //Write a C# Sharp program to check two given integers and return the value whichever value is nearest to 13 without going over.
            //Return 0 if both numbers go over.

            if (a > 13 && b > 13) return 0;
            if (a > 13) return b;
            if (b > 13) return a;
            if (a > b) return a;
            else return b;
        }

        private static bool CheckDifference(int a, int b, int c)
        {
            //No. 59
            //Write a C# Sharp program to check three given integers (small, medium and large) and return true
            //if the difference between small and medium and the difference between medium and large is same.

            //6 combinations

            if (a > b && a > c && b > c) return a - b == b - c;
            if (a > b && a > c && c > b) return a - b == c - b;
            if (b > a && b > c && a > c) return b - a == a - c;
            if (b > a && b > c && c > a) return b - a == c - a;
            if (c > a && c > b && a > b) return c - a == a - b;
            return (c - b == b - a);
        }


        private static string InsertString(string str1, string str2)
        {
            //NO 61
            //Write a C# Sharp program to insert a given string into middle of the another given string of length 4.
            return str1.Substring(0, str1.Length / 2) + str2 + str1.Substring(str1.Length / 2);
        }

        private static string MakeStringYP(string str1)
        {
            //NO 85
            //Write a C# Sharp program to create a new string from a given string without the first two characters.
            //Keep the first character if it is "p" and keep the second character if it is "y".
            if (str1.Length >= 2)
            {
                if (String.Compare(str1.Substring(1, 1), "y") != 0)
                {
                    str1 = str1.Remove(1, 1);
                }
                if (String.Compare(str1.Substring(0, 1), "p") != 0)
                {
                    str1 = str1.Remove(0, 1);
                }
            }
            else
            {
                if (str1.Length > 0 && String.Compare(str1.Substring(0, 1), "p") != 0)
                {
                    str1 = str1.Remove(0, 1);
                }
            }
            return str1;

        }

        private static string MakeStringAA(string str1) 
        {
            //NO 87
            //Write a C# Sharp program to create a new string from a given string. If the first or first two characters is 'a',
            //return the string without those 'a' characters otherwise return the original given string.
            if (str1.Length > 1)
            {
                if (str1.Substring(1,1) == "a")
                {
                    str1 = str1.Remove(1, 1);
                }
                if (str1.Substring(0, 1) == "a")
                {
                    str1 = str1.Remove(0, 1);
                }
            }
            else if (str1.Length > 0 && str1.Substring(0, 1) == "a")
            {
                str1 = str1.Remove(0, 1);
            }
            return str1;
        }

        private static bool CheckArray(int[] a) 
        {
            //NO 89
            //Write a C# Sharp program to check a given array of integers of length 1 or more and
            //return true if the first element and the last element are equal in the given array.
            return a[0] == 10 || a[a.Length - 1] == 10;
        }

        private static bool CheckTwoArrays(int[] a, int[] b) 
        {
            //NO 90
            //Write a C# Sharp program to check two given arrays of integers of length 1
            //or more and return true if they have the same first element or they have the same last element.

            return a[0] == b[0] || a[a.Length - 1] == b[a.Length - 1];
        }

        private static int ArraySum(int[] a) 
        {
            //NO 91
            //Write a C# Sharp program to compute the sum of the elements of an given array of integers.

            //Solution with Array method if .net version > 3.5
            //return a.Sum();

            int sum = 0;
            for (int i = 0; i <= a.Length-1; i++)
            {
                sum += a[i];
            }
            return sum;
    
        }

        private static string ReverseArrayToString(int[] a) 
        {
            //NO 92
            //Write a C# Sharp program to reverse the elements of a given array of integers (length 4 ) in left direction and return the new array. 

            //Solution with Array method if .net version > 3.5
            //return a.Reverse().ToString();

            var array = ReverseArray(a);
            string s = String.Empty;

            foreach (var item in array)
            {
                s += item.ToString() + " ";
            }
            return s;
        }

        private static int[] ReverseArray(int[] a) 
        {


            int[] b = new int[a.Length];

            for (int i = a.Length - 1, y = 0; i >= 0; i--, y++)
            {
                b[y] = a[i];
            }
            return b;
        }

        private static bool CheckArrayDoubles(int[] a)
        {
            //NO 100
            //Write a C# Sharp program to check a given array of integers and return true if the array contains 10 or 20 twice.
            //The length of the array will be 0, 1, or 2.
            return a.Length == 2 && (a[0] == 10 && a[1] == 10 || a[0] == 20 && a[1] == 20);
        }
    }
}
