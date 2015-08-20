using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Distance =");
            double dis2 = Convert.ToDouble(Console.ReadLine());
            double fixedCharge2 = 2.40;
            double addFare2 = 0.4;
            double totalFare2 = fixedCharge2 + dis2 * addFare2;
            Console.Write("Total Fare : " + string.Format("{0:0.00}", Math.Ceiling(totalFare2 * 10) / 10));
            Console.ReadLine();
        }
    }
}
