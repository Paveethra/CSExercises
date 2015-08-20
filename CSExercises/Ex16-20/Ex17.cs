using System;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your Name :");
            string name = Console.ReadLine();
            Console.Write("Enter Your Gender(M/F) :");
            string gender = Console.ReadLine();
            Console.Write("Enter Your Age :");
            int age = Convert.ToInt32(Console.ReadLine());

            if (gender.ToUpper().Equals("M"))
            {
                if (age >= 40)
                    Console.WriteLine("Good Morning Uncle {0}", name);
                else
                    Console.WriteLine("Good Morning Mr.{0}", name);
            }
            else if (gender.ToUpper().Equals("F"))
            {
                if (age >= 40)
                    Console.WriteLine("Good Morning Aunty {0}", name);
                else
                    Console.WriteLine("Good Morning Ms.{0}", name);
            }
            Console.Read();
        }
    }
}
