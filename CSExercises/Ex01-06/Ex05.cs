using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Double Precision Number: ");
            double no4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Square of the input : {0} ", Math.Round(Math.Sqrt(no4), 3));
            Console.Read();
        }
    }
}

