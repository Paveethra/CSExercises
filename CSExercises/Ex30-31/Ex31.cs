using System;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {

            int count;
            for (int z = 1; z < 1000; z++)
            {
                count = 0;
                for (int x = 2; x < z; x++)
                {
                    if (z % x == 0)
                    {
                        count += z;
                    }
                }

                if (count == z)
                    Console.Write(z+" ");
            }
            Console.Read();
        }
    }
}
