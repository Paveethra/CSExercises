using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Distance =");
            double dis = Convert.ToDouble(Console.ReadLine());
            double fixedCharge = 2.40;
            double addFare = 0.4;
            double totalFare = fixedCharge + dis * addFare;
            Console.Write("Total Fare : " + totalFare);
            Console.ReadLine();
        }
    }
}
