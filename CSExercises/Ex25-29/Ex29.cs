using System;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Number :");
            int no = Convert.ToInt32(Console.ReadLine()), count = 0, remainder = 1;

            for (int i = 2; i < no; i++)
            {
                if (no % i == 0)
                {
                    remainder += i;
                    // count++;
                }
            }
            if (remainder == no)
                Console.WriteLine("Given Number is Perfect");
            else
                Console.WriteLine("Given Number is not Perfect");
            Console.Read();
        }
    }
}
