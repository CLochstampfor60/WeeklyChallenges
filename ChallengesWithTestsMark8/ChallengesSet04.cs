using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

/*using System;
using System.Linq;*/

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {

            /*           int newTotal = 0;
                       foreach (int number in numbers)
                       {
                           if (number % 2 == 0)
                           {
                               newTotal += number;
                           }
                           else
                           {
                               newTotal -= number;
                           }
                       }
                       return newTotal;*/

            return numbers.Where(num => num % 2 == 0).Sum() - numbers.Where(num => num % 2 != 0).Sum();


        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] newList = { str1, str2, str3, str4 };
            return newList.Min(x => x.Length);

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] ints = { number1, number2, number3, number4 };
            return ints.Min();

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out var number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullTotal = objs.Where(x => x == null).Count();
            if (nullTotal > objs.Length / 2)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null) return 0;
            var evensSum = numbers.Where(x => x % 2 == 0);
            if (evensSum.Count() == 0 || evensSum == null || !evensSum.Any())
            {
                return 0;
            }

            return evensSum.Average();

        }

        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException();
            if (number == 0)
                return 1;
            else
                return number * Factorial(number - 1);
        }
    }
}
