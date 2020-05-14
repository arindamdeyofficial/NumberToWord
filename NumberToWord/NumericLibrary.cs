using System.Text;

namespace NumberToWord
{
    public class NumericLibrary: INumericLibrary
    {
        readonly string[] nums = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
        readonly string[] teens = new string[] { "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty" };
        readonly string[] tens = new string[] { "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        public string NumberToWord(int num)
        {
            int n = num;
            StringBuilder result = new StringBuilder();

            if (n <= 10)
            {
                return nums[n].ToString();
            }
            else if (n <= 20)
            {
                return teens[n - 11].ToString();
            }

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
                    
                }
                if (n < 10)
                {
                    result.Insert(0, " ");
                    result.Insert(0, tens[n - 2]);
                    break;
                }
                count++;
            }
            return result.ToString();
        }
    }
}
