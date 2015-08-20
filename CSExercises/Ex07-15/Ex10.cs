using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter X1 =");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y1 =");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter X2 =");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y2 =");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.Write("Distance = {0}", distance);
            Console.ReadLine();
        }
    }
}

