using System;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Number :");
            int no = Convert.ToInt32(Console.ReadLine()), count = 0;

            for (int i = 2; i < no; i++)
            {
                if (no % i == 0)
                    count++;
            }
            if (count == 0)
                Console.WriteLine("Given Number is prime");
            else
                Console.WriteLine("Given Number is not prime");
            Console.Read();
        }
    }
}
