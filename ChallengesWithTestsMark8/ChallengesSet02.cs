using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            
            /*If val.Length is Even, return true, else return false*/
 /*           bool result = false;

            for (int i = 0; i < vals.Length; i++)
            {
               if ( )

            }*/
            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
                return true;
            return false;
            
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
                return true;
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                throw new ArgumentNullException(nameof(str1));

            if (str2 == null) throw new ArgumentNullException(nameof(str2));

    /*        int length = 0;*/
           
            
            if (str1.Length > str2.Length)
            {
               
                return str1.Length;
            } else
            {
                
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null) return 0;

            var result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null) return 0;

            var evensTotal = 0;
            foreach (var item in numbers) { 
                if (item % 2 == 0)
                {
                    evensTotal += item;
                }            
            }
            return evensTotal;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) return false;
            var result = true;
            foreach (var item in numbers)
            {
                if (item % 2 != 0) result = true;
                result = false;
            }
            return (result);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
