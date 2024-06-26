﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c)) return true;
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            /*The count of elements is even or odd...not the sum of all numbers is even or odd*/
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else { return false; }

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

            if (numbers == null || !numbers.Any()) return 0;

            double max = numbers.Max();
            double min = numbers.Min();

            return max + min;

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
           
            if (str1.Length < str2.Length)
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
            if (numbers == null || !numbers.Any()) return false;

            int count = 0;
            for (int i = 0;i < numbers.Count;i++)
            {
                count += numbers[i];
            }

            if (count % 2 != 0) return true;
            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {

            long counter = 0; 

            for (var i = 0; i < number; i++)
            {
                if (i % 2 != 0 && i > 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
