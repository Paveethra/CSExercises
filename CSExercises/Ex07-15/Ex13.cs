using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Distance =");
            double dis3 = Convert.ToDouble(Console.ReadLine());
            double fixedCharge3 = 2.40;
            double addFare3 = 0.4;
            double totalFare2 = fixedCharge3 + dis3 * addFare3;
            Console.Write("Total Fare : " + string.Format("{0:0.00}", Math.Floor(totalFare2 * 10) / 10));
            Console.ReadLine();
        }
    }
}
