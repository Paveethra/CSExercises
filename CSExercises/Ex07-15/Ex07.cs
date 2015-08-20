using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Salary amount: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            var houseAllowance = ((double)10 / 100) * salary;
            var transportAllowance = ((double)3 / 100) * salary;
            var total = salary + houseAllowance + transportAllowance;
            Console.WriteLine("Total : {0} ", total.ToString("C0"));
            Console.Read();
        }
    }
}
