using System;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            int fact = 1;

            //a
            Console.Write("Enter Number to find factorial :");
            int ip = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= ip; i++)
            {

                fact = fact * i;
            }

            Console.WriteLine("Factorial of {0} is {1}", ip, fact);
            Console.Read();


            //b
            fact = 1;
            for (int i = ip; i > 1; i--)
            {

                fact = fact * i;
            }

            Console.WriteLine("Factorial of {0} is {1}", ip, fact);
            Console.Read();


        }
    }
}
