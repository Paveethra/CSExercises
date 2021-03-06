using System;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Random r = new Random();

            Console.Write("Enter Number :");
            double input = Convert.ToDouble(Console.ReadLine());
            double N = Math.Sqrt(input);

            double guess = r.Next(1, Convert.ToInt32(N));


            if (input == guess)
            {

                if (N == guess * guess)
                    Console.Write("Success at first attempt");
            }
            else
            {
                while (input != guess)
                {
                    guess = (guess + Convert.ToDouble(N) / guess) / 2.0;
                    guess = Math.Round(guess, 5);

                    if (guess * guess == N)
                    {
                        Console.Write("Success");
                        break;
                    }
                    else
                    {
                        Console.Write("Fail");
                    }
                }
            }
        }
    }
}
