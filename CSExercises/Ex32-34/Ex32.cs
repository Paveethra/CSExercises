using System;
using System.Linq;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int[] info = new int[12];
            double sum = 0;
            string[] sales = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            for (int i = 0; i < sales.Length; i++)
            {
                Console.Write("Enter sales for month {0} :", sales[i]);
                info[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + info[i];

            }

            Console.WriteLine("Maximum Sales : {0}", info.Max());
            Console.WriteLine("Minimum Sales : {0}", info.Min());
            Console.WriteLine("Avergae Sales : {0}", sum / info.Length);
            Console.ReadLine();

        }
    }
}
