using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**/
            Console.WriteLine("#1");
            Console.Write("Input num from 1 to 100: ");
            string text1 = Console.ReadLine();
            int.TryParse(text1, out int s);
            bool k = false;
            if (1 <= s && s <= 100)
            {
                if (s % 3 == 0)
                {
                    Console.Write("Fizz");
                    k = true;
                }
                if (s % 5 == 0)
                {
                    if (k)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("Buzz");
                    k = true;
                }
                if (!k)
                {
                    Console.WriteLine(s);
                }
                else
                {

                    Console.WriteLine("");
                }

            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine("#2");
            Console.Write("Input num: ");
            string text2 = Console.ReadLine();
            Console.Write("Input %: ");
            string text3 = Console.ReadLine();

            float.TryParse(text2, out float num);
            float.TryParse(text3, out float pr);
            Console.WriteLine($"{pr}% from {num} = {pr*num/100}");

            Console.WriteLine("#3");
            Console.Write("Input num 1 (from 0 to 9): ");
            string text4 = Console.ReadLine();
            Console.Write("Input num 2 (from 0 to 9): ");
            string text5 = Console.ReadLine();
            Console.Write("Input num 3 (from 0 to 9): ");
            string text6 = Console.ReadLine();
            Console.Write("Input num 4 (from 0 to 9): ");
            string text7 = Console.ReadLine();

            int.TryParse(text4, out int num1);
            int.TryParse(text5, out int num2);
            int.TryParse(text6, out int num3);
            int.TryParse(text7, out int num4);

            if (num1 < 0 || num1 > 9 ||
                num2 < 0 || num2 > 9 ||
                num3 < 0 || num3 > 9 ||
                num4 < 0 || num4 > 9)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                Console.WriteLine("Ans:" + (num1 * 1000 + num2 * 100 + num3 * 10 + num4));
            }

            Console.WriteLine("#4");
            Console.Write("Input num 1 (from 100000 to 999999): ");
            string text8 = Console.ReadLine();
            Console.Write("Input num 2 (from 1 to 6): ");
            string text9 = Console.ReadLine();
            Console.Write("Input num 3 (from 1 to 6): ");
            string text10 = Console.ReadLine();

            int.TryParse(text8, out int num5);
            int.TryParse(text9, out int num6);
            int.TryParse(text10, out int num7);
            if (num7 < 1 || num7 > 6 ||
                num6 < 1 || num6 > 6 ||
                num5 < 100000 || num5 > 999999)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                char[] chars = text8.ToCharArray();

                char temp = chars[num6 - 1];
                chars[num6 - 1] = chars[num7 - 1];
                chars[num7 - 1] = temp;

                string result4 = new string(chars);
                Console.WriteLine("Ans:" + result4);
            }

            Console.WriteLine("#5");
            Console.Write("Input date: ");
            string text11 = Console.ReadLine();
            if (DateTime.TryParse(text11, out DateTime date5))
            {
                Console.Write("Day " + date5 + " is ");
                int t5 = date5.Month;
                if (t5 == 12 || t5 == 1 || t5 == 2)
                {
                    Console.WriteLine(" Winter " + date5.DayOfWeek);
                }
                else if (t5 == 3 || t5 == 4 || t5 == 5)
                {
                    Console.WriteLine(" Winter " + date5.DayOfWeek);
                }
                else if (t5 == 6 || t5 == 7 || t5 == 8)
                {
                    Console.WriteLine(" Winter " + date5.DayOfWeek);
                }
                else if (t5 == 9 || t5 == 10 || t5 == 11)
                {
                    Console.WriteLine(" Winter " + date5.DayOfWeek);
                }
                else
                {
                    Console.WriteLine("idk wt u wnt");
                }
            }
            else
            {
                Console.WriteLine("idk wt u wnt");
            }
            

            Console.WriteLine("#6");
            Console.Write("Input temperature: ");
            string text12 = Console.ReadLine();
            if (decimal.TryParse(text12, out decimal nums6))
            {

                Console.Write("Input (Y if to cels or N to farngt): ");
                string text13 = Console.ReadLine();
                if (text13 == "Y")
                {
                    Console.WriteLine("ans: " + nums6 * 9 / 5 + 32 + " farngt");

                }
                else if (text13 == "N")
                {
                    Console.WriteLine("ans: " + (nums6 - 32) / 9 * 5 + " cels");
                }
                else
                {
                    Console.WriteLine("idk wt u wnt");
                }
            }
            else
            {
                Console.WriteLine("idk wt u wnt");
            }

            Console.WriteLine("#7");

            Console.Write("Input num 1: ");
            string num7_1t = Console.ReadLine();
            Console.Write("Input num 2: ");
            string num7_2t = Console.ReadLine();

            if (int.TryParse(num7_1t, out int num7_1) && int.TryParse(num7_2t, out int num7_2))
            {
                int count7 = 0;
                if (num7_1 > num7_2) { (num7_1, num7_2) = (num7_2, num7_1); }
                for (int i = num7_1; i <= num7_2; i++)
                {
                    if (i % 2 == 0)
                    {
                        count7++;
                    }
                }
                Console.WriteLine("Even: " + count7);
            }
            else
            {
                Console.WriteLine("idk wt u wnt");
            }
            Console.WriteLine("#8");
            Console.Write("Input num: ");
            string num8t = Console.ReadLine();
            if (int.TryParse(num8t, out int num8))
            {
                int pow = num8t.Length;
                long sum = 0;
                foreach (char tl in num8t){
                    sum += (long)Math.Pow(tl - '0', pow);
                }
                if (sum == num8)
                {
                    Console.WriteLine("Ans: number is Armstrong number");
                }
                else
                {
                    Console.WriteLine("Ans: number isn't Armstrong number");
                }
            }
            else
            {
                Console.WriteLine("idk wt u wnt");
            }
            

            // Number is perfect ONLY if number = 2^(p-1)*(2^p - 1) and 2^p - 1 is prime number (all 2^p - 1 primes is "Mersenne primes")
            // (Leonhard Euler proof)
            Console.WriteLine("#9");
            long[] mersenne_primes_p = { 2, 3, 5, 7, 13, 17, 19, 31, 61, 89, 107, 127, 521, 607, 1279, 2203, 2281, 3217,
                4253, 4423, 9689, 9941, 11213, 19937, 21701, 23209, 44497, 86243, 110503, 132049, 216091, 756839, 859433,
                1257787, 1398269, 2976221, 3021377, 6972593, 13466917, 20996011, 24036583, 25964951,
                30402457, 32582657, 37156667, 42643801, 43112609, 57885161, 74207281, 77232917, 82589933, 136279841 };
            // These are all the p koof in Mersenne primes known to us as of 2024;
            Console.Write("Input num: ");
            string num9t = Console.ReadLine();
            if (int.TryParse(num9t, out int num9))
            {
                bool k9 = false;
                foreach (long i in mersenne_primes_p)
                {
                    if (i > 14) continue;
                    long mp = pow(2, (i)) - 1;
                    //Console.WriteLine(mp);
                    //Console.WriteLine(pow(2, (mp - 1)) * (pow(2, mp) - 1));
                    if (pow(2, (mp-1))*(pow(2, mp) - 1) == num9)
                    {
                        k9 = true;
                        break;
                    }
                }
                Console.WriteLine("Ans: " + k);
            }
            else
            {
                Console.WriteLine("idk wt u wnt");
            }


        }

        static long pow(long n1, long n2)
        {
            long n = 1;
            for (int i = 0; i < n2; i++)
            {
                n *= n1;
            }
            return n;
        }


    }
}
