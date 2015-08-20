using System;
namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a =");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b =");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter c =");
            double c = Convert.ToDouble(Console.ReadLine());
            double s = (a + b + c) / 2;

            if (a + b > c && a + c > b && c + b > a)
            {
                double area = Math.Sqrt(s * (s - a) - (s - b) * (s - c));
                Console.WriteLine("Area of triangle : " + area);
            }
            else
            {
                Console.WriteLine("Length of 3 Side's incorrect, they dont form traingle");
            }
            Console.ReadLine();
        }
    }
}
