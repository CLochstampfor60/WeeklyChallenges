using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        //DONE
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //DONE
        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;

        }

        //DONE
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        //DONE
        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number2;
            }
            else if (number1 < number2)
            {
                return number1;
            }
            else
            {
                // If both number1 and number2 are equal, either interger can be returned.
                return number1;

            }

        }

        //DONE
        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }


        // DONE
        public string GetGreeting(string jollyPerson)
        {
            if (jollyPerson == "")
            {
                return "Hello!";

            }
            else
            {
                return $"Hello, {jollyPerson}!";
            }
        }

        //DONE
        public string GetHey()
        {
            var getHey = "HEY!";
            return getHey;
        }

    }


}
