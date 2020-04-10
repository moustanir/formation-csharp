using System;
using System.Collections.Generic;

namespace LittleExercices
{
    class Program
    {

        /// <summary>
        /// Returns sum of two integers
        /// </summary>
        /// <param name="numberA"></param>
        /// <param name="numberB"></param>
        /// <returns></returns>
        public static int Exercice1(int numberA, int numberB)
        {
            return numberA + numberB;
        }

        /// <summary>
        /// Returns a string which contains a greeting
        /// </summary>
        /// <param name="name">Name of a person that we intend to greet</param>
        /// <returns></returns>
        public static string Exercice2(string name)
        {
            return $"Greeting, {name}. How are you today ?";
        }

        /// <summary>
        /// Returns the sum of the numbers 1 to n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Exercise3(int n)
        {
            int result = 0;
            for (int index = 1; index <= n; index++)
            {
                result += index;
            }
            return result;
        }

        /// <summary>
        /// Returns info if number entered is a prime number or not
        /// </summary>
        /// <param name="number"></param>
        /// <returns>String which contains informations</returns>
        public static string Exercice4(int number)
        {
            for (int index = 2; index < number; index++)
            {
                if (number % index == 0)
                {
                    return $"{number} is not a prime number";
                }
            }
            return $"{number} is a prime number";
        }
        
        /// <summary>
        /// Returns the factorial of a number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string Exercice5(int number)
        {
            int result = 1;
            if (number < 1)
            {
                return "Cannot do the factorial of negative number";
            }
            for (int index = 2; index <= number; index++)
            {
                result *= index;
            }
            return $"The factorial of {number} is {result}";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string Exercice6(int num)
        {
            String x = "";

            // Changed num variable to string, 
            // and calculated the length (number of digits)
            int order = (num.ToString()).Length;

            // initialize sum
            int sum = 0;

            // find the sum of the cube of each digit
            int temp = num;
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, order);
                temp = temp / 10;
            }

            // display the result
            if (num == sum)
                x = num + " is an Armstrong number";
            else
                x = num + " is not an Armstrong number";
            return x;
        }
        /// <summary>
        /// Check if a number is ugly or not
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool Exercice7(int number)
        {
            List<int> primeFactors = new List<int>();
            if(number < 1)
            {
                throw new Exception();
            }
            for(int index = 2; index < number; index++)
            {
                if (number % index == 0)
                {
                    primeFactors.Add(index);
                }
            }
            if(primeFactors.Count == 1 && (primeFactors.Contains(2) || primeFactors.Contains(3) || primeFactors.Contains(5)))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Exercice8(int number)
        {
            int a = 2, b = 1, c;

            if (number == 0)
                return a;

            // generating number 
            for (int index = 2; index <= number; index++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Exercice7(26));
            Console.ReadLine();
        }
    }
}
