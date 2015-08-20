using System;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double minCharge = 2.40, //0.5kms
                   nextCharge = 0.04,//4 cent for 100m 4/100, next 8.5kms
                   aftrEveryCharge = 0.05, // 5 cent per 100m
                   calculate;

            Console.WriteLine("Enter Distance Travelled in Km:");
            double distance = Convert.ToDouble(Console.ReadLine());
            distance = (Math.Ceiling(distance * 10)) / 10;


            if (distance <= 9)
            {
                calculate = minCharge + (distance - 0.5) * 10 * nextCharge;
            }
            else
            {
                calculate = minCharge + (8.5) * 10 * nextCharge + (distance * 10 - 90) * aftrEveryCharge;

            }

            Console.WriteLine("Total Amount : {0:C}", Math.Round(calculate, 2));
            Console.Read();

        }
    }
}
