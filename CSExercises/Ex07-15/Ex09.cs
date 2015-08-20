using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Input for X =");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = (double)((2 * Math.Pow(x, 2)) - (4 * x) + 3);
            Console.WriteLine("Output Y = {0}", y);
            Console.Read();
        }
    }
}
