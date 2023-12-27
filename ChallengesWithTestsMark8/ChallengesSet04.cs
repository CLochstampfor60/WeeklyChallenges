using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;

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
            /*  return biz[String.IndexOf(biz, 0)] = "TrueCoders";*/

            return Business.Remove();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(x => x == null).Add().Then();
        }

        public double AverageEvens(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
