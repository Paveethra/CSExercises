using System;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int guess = r.Next(0, 10), count = 1, no;

            Console.Write("Think of a number :");
            no = Convert.ToInt32(Console.ReadLine());

            while (no != guess)
            {
                count++;
                Console.Write("Try Again :");
                no = Convert.ToInt32(Console.ReadLine());
            }



            switch (count)
            {
                case 1:
                    Console.WriteLine("You are a wizard!");
                    break;
                case 2:
                    Console.WriteLine("You are a good guess!");
                    break;
                case 3:
                    Console.WriteLine("You are a lousy!");
                    break;
                default:
                    Console.Write("Guessed in {0} attempts!!", count);
                    break;
            }

            Console.Read();


        }
    }
}
