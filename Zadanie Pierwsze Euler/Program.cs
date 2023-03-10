using System;

namespace NumbersInWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalLetters = 0;
            for (int i = 1; i <= 1000; i++)
            {
                totalLetters += NumberToWords(i).Length;
            }
            Console.WriteLine("The total number of letters is: " + totalLetters);
        }

        static string NumberToWords(int num)
        {
            string[] ones = {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                             "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
            string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (num < 20)
            {
                return ones[num];
            }
            if (num < 100)
            {
                return tens[num / 10] + ones[num % 10];
            }
            if (num < 1000)
            {
                return ones[num / 100] + "hundred" + ((num % 100 != 0) ? "and" + NumberToWords(num % 100) : "");
            }
            if (num == 1000)
            {
                return "onethousand";
            }
            return "";
        }
    }
}
