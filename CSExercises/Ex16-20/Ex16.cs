using System;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your Name :");
            string name = Console.ReadLine();
            Console.Write("Enter Your Gender(M/F) :");
            string gender = Console.ReadLine();

            if (gender.ToUpper().Equals("M"))
                Console.WriteLine("Good Morning Mr.{0}", name);
            else if (gender.ToUpper().Equals("F"))
                Console.WriteLine("Good Morning Ms.{0}", name);
            Console.Read();


        }
    }
}

