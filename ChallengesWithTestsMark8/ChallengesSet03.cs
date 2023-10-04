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
            throw new NotImplementedException();

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
            /*     for (int i = 0; i < password.Length; i++)
                 {
                     foreach(char c in password)
                     {
                         if (c == ' ') return false;
                         if (c % 2 == 0) return true;

                     }

                 }*/
            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            
            return val.ToCharArray()[0];
               
        }

        public char GetLastLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            /*  var start = new int[1];*/

            /*  for (var i = 0; i <= 100; i++)
              {
                  start[i] = i;
                  i++;
                  return start;
              }*/
            throw new NotImplementedException();
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
