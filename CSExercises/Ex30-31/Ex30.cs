using System;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            bool isPrime = true;
            Console.WriteLine("Prime Numbers : ");
            for (int i = 5; i <= 10000; i++)
            {
                for (int j = 2; j <= 10000; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }
}
