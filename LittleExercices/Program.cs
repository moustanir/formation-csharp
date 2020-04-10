using System;

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
        public int Exercice1(int numberA, int numberB)
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
        public int Exercise3(int n)
        {
            int result = 0;
            for(int index = 1; index <= n; index++)
            {
                result += index;
            }
            return result;
        }
        /// <summary>
        /// Returns info if number entered is a prime number or not
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns>String which contains informations</returns>
        public string Exercice4(int number)
        {
            for(int index = 2; index < number; index++)
            {
                if (number % index == 0)
                {
                    return $"{number} is not a prime number";
                }
            }
            return $"{number} is a prime number";
        }
        static void Main(string[] args)
        {
               
        }
    }
}
