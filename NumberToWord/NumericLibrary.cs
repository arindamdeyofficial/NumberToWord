using System.Text;

namespace NumberToWord
{
    public class NumericLibrary: INumericLibrary
    {
        readonly string[] nums = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        readonly string[] teens = new string[] { "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        readonly string[] tens = new string[] { "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        public string SpellNumber(int num)
        {
            StringBuilder result = new StringBuilder();

            if (num <= 20)
                return BasicNumberToWord(num);
            else
            {
                int[] a = SegrigateNumberSystem(num);
                for (var c = (a.Length - 1); c >= 0; c--)
                {
                    int e = a[c];
                    if (e == 0) continue;
                    var w = NumberToWord(e, c);
                    result.Append(NumberToWord(e, c));
                }
            }


            return result.ToString();
        }
        private string NumberToWord(int num, int position)
        {
            int n = num;
            StringBuilder result = new StringBuilder();
            result.Insert(0, " ");
            if (position == 0)
            {
                result.Insert(0, DecimalNumberToWord(n));
            }
            else if (position == 1)
            {
                result.Insert(0, " Hundred");
                result.Insert(0, DecimalNumberToWord(n));
            }
            else if (position == 2)
            {
                result.Insert(0, " Thousand");
                result.Insert(0, DecimalNumberToWord(n));
            }
            else if (position == 3)
            {
                result.Insert(0, " Lakh");
                result.Insert(0, DecimalNumberToWord(n));
            }
            else if (position == 4)
            {
                result.Insert(0, " Crore");
                result.Insert(0, DecimalNumberToWord(n));
            }

            return result.ToString();
        }
        private int[] SegrigateNumberSystem(int num)
        {
            int[] arr = new int[5];
            int n = num;
            bool extraLastCount = false;
            int arrIndex = 0;
            for (var numIndex = 0; n > 0; numIndex++)
            {
                int r = n % 10;
                n /= 10;

                if ((numIndex == 1) || (numIndex == 4) || (numIndex == 6)) { arr[arrIndex - 1] = arr[arrIndex - 1] + r * 10; arrIndex--; }
                else arr[arrIndex] = r;
                if (extraLastCount) break;
                arrIndex++;
                extraLastCount = n < 10;
            }
            return arr;
        }
        private string BasicNumberToWord(int n)
        {
            if (n < 10)
            {
                return nums[n].ToString();
            }
            else if ((n > 10) && (n < 20))
            {
                return teens[n - 11].ToString();
            }
            else if (n % 10 == 0)
            {
                return tens[n / 10 - 1].ToString();
            }
            return n.ToString();
        }
        private string DecimalNumberToWord(int n)
        {
            StringBuilder result = new StringBuilder();
            if (n < 21)
            {
                result.Insert(0, BasicNumberToWord(n));
            }
            else if (n % 10 == 0) // 10,20,30 etc.
            {
                result.Insert(0, tens[n / 10 - 1]);
            }
            else
            {
                int r = n % 10;
                n /= 10;
                result.Insert(0, nums[r]);
                result.Insert(0, " ");
                result.Insert(0, tens[n - 1]);
            }
            return result.ToString();
        }
    }
}
