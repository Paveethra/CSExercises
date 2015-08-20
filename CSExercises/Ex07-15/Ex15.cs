using System;
namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter 3 digit number :");
            string no15 = Console.ReadLine();
            int val, arm, sum = 0;
            if (no15.Length.Equals(3) && int.TryParse(no15, out val))
            {
                while (val != 0)
                {
                    arm = val % 10;
                    val = val / 10;
                    sum += arm * arm * arm;
                }

                if (Convert.ToInt32(no15).Equals(sum))
                {
                    Console.WriteLine("Entered Number is Armstrong");
                }
                else
                {
                    Console.WriteLine("Entered Number is not Armstrong");
                }

            }
            else
            {
                Console.Write("Enter Valid Input");
            }
            Console.Read();
        }
    }
}
