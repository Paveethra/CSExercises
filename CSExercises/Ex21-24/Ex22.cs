using System;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int a, b, HCF = 0;

            //1
            Console.Write("Enter A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B:");
            b = Convert.ToInt32(Console.ReadLine());

            int a1 = a, b1 = b;

            while (a1 != b1)
            {
                if (a1 > b1)
                {
                    a1 = a1 - b1;
                    HCF = a1;
                }
                else
                {

                    b1 = b1 - a1;
                    HCF = b1;
                }
            }


            Console.WriteLine("HCF :{0}", HCF);
            Console.WriteLine("LCM :{0}", (a * b) / (HCF));
            Console.ReadLine();
        }
    }
}

// while (minVal!=maxVal);
//Console.WriteLine("HCF :{0}",minVal);
//while(Num2!=0)
//{
//    temp = Num2;
//    Num2 = Num1 % Num2;
//    Num1 = temp; 
//}

//Console.WriteLine("HCF :{0}",Num1);
// int Num1 = a, Num2 = b;
//} while (minVal!=maxVal);
//    maxVal -= minVal;
//do{ //2

