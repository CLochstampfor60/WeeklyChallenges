using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if(vals.Contains(false)) return true;
            else return false;
      

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || !numbers.Any()) return false;

            int count = 0;

/*            for (int i = 0; i < numbers.Count(); i++)
                count += i;

            if (count % 2 != 0) return true;
            return false;*/

            foreach (var n in numbers)
            {
                count += n;
            }

            if (count % 2 == 0) return false;
            else return true;


        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

            bool anyUpper = password.Any(char.IsUpper);
            bool anyLower = password.Any(char.IsLower);
            bool anyNumber = password.Any(char.IsNumber);

          if (anyUpper && anyLower && anyNumber) return true;
            return false;

        }

        public char GetFirstLetterOfString(string val)
        {

            /*return val.ToCharArray()[0];*/
            return val[0];
               
        }

        public char GetLastLetterOfString(string val)
        {
           return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
      
            return divisor == 0 ? 0 : dividend / divisor;

        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] newArray = new int[50];
            int list = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 !=0)
                {
                    newArray[list] = i;
                    list++;
                }
      
            }
            return newArray;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
