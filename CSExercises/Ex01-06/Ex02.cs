using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Integer Number: ");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Square of the input : {0} ", Math.Pow(no, 2));
            Console.Read();
        }
    }
}
