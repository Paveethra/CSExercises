using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Centigrade: ");
            double centigrade = Convert.ToDouble(Console.ReadLine());
            double convertToFah = ((double)(1.8 * centigrade)) + 32;
            Console.WriteLine("Centigrade = {0} | Fahrenheit = {1} ", centigrade, convertToFah);
            Console.Read();
        }
    }
}
