using System;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Mark between 0-100 :");
            int mark = Convert.ToInt32(Console.ReadLine());

            if (mark >= 80)
                Console.WriteLine("Grade : A");
            else if (mark == 60 || mark <= 79)
                Console.WriteLine("Grade : B");
            else if (mark == 40 || mark <= 59)
                Console.WriteLine("Grade : C");
            else if (mark == 0 || mark <= 40)
                Console.WriteLine("Grade : F");
            else if (mark < 0 || mark > 100)
                Console.WriteLine("Enter Value Between 0-100!");

            Console.ReadLine();


        }
    }
}
