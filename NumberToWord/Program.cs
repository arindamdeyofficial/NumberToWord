using System;
using System.Text;

namespace NumberToWord
{
    class Program
    {
        static readonly string[] nums = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
        static readonly string[] teens = new string[] { "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty" };
        static readonly string[] tens = new string[] { "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            int n = Int32.Parse(num);
            StringBuilder result = new StringBuilder();
            
            int count = 0;
            while (true)
            {
                int r = n % 10;
                n /= 10;
                result.Insert(0, " ");

                if (count == 1) //Teens
                {
                    result.Insert(0, tens[r]);
                }
                else
                {
                    result.Insert(0, nums[r]);
                    if (count == 2)//hundred
                        result.Insert(0, " Hundred");
                    else if (count == 3)
                        result.Insert(0, " Thousand");
                }
                if (n < 10)
                {
                    result.Insert(0, " ");
                    result.Insert(0, tens[n - 2]);
                    break;
                }
                count++;
            }
            Console.WriteLine(result.ToString());
        }
    }
}
