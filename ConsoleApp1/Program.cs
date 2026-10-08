namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("Ans:", num1 * 1000 + num2 * 100 + num3 * 10 + num4);
            }

            Console.WriteLine("#3");
            Console.Write("Input num 1 (from 100000 to 999999): ");
            string text8 = Console.ReadLine();
            Console.Write("Input num 2 (from 1 to 6): ");
            string text9 = Console.ReadLine();
            Console.Write("Input num 3 (from 1 to 6): ");
            string text10 = Console.ReadLine();

            int.TryParse(text8, out int num5);
            int.TryParse(text9, out int num6);
            int.TryParse(text10, out int num7);
            if (num5 < 1 || num5 > 6 ||
                num6 < 1 || num6 > 6 ||
                num7 < 100000 || num7 > 999999)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                Console.WriteLine("Ans:", num1 * 1000 + num2 * 100 + num3 * 10 + num4);
            }











        }
    }
}
