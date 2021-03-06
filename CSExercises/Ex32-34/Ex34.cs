using System;
using System.Linq;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            string[] name = new string[] { "N1", "N2", "N3", "N4", "N5", "N6", "N7", "N8", "N9", "N10", "N11", "N12" };
            int[,] marks = new int[,]{
                                        {40,50,60,85},
                                        {41,51,61,86},
                                        {42,52,62,87},
                                        {43,53,63,88},
                                        {44,54,64,89},
                                        {45,55,65,90},
                                        {46,56,66,91},
                                        {47,57,67,92},
                                        {48,58,68,93},
                                        {49,59,69,94},
                                        {50,60,70,95},
                                        {51,61,71,96},
                                    };

            //a
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine();
                Console.Write("Student name :" + name[i]);
                for (int j = 0; j < 4; j++)
                {
                    sum = sum + marks[i, j];
                }
                Console.WriteLine(",Total_Marks :" + sum);
            }




            //b
            int loop = 1, classSUM = 0;
            double avgSub;
            Console.WriteLine(string.Concat(Enumerable.Repeat('*', 50)));
            while (loop <= 4)
            {

                for (int i = 0; i < name.Length; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        classSUM += marks[i, j];
                    }

                }
                avgSub = Convert.ToDouble(classSUM) / Convert.ToDouble(name.Length);
                Console.WriteLine("Average of Subject {0} : {1:0.000}", loop, avgSub);
                //classSUM / name.Length
                loop++;
            }

            int subSum = 0, totalSum = 0;
            double avg;
            Console.WriteLine(string.Concat(Enumerable.Repeat('*', 50)));
            for (int i = 0; i < name.Length; i++)
            {
                subSum = 0;
                for (int j = 0; j < 4; j++)
                {

                    subSum += marks[i, j];
                }
                totalSum += subSum;
            }

            avg = Convert.ToDouble(totalSum) / Convert.ToDouble(12 * 4);
            Console.WriteLine("Average of Whole Class for all marks :{0:0.000}", avg);



            Console.Read();

        }
    }
}




