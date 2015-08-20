using System;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            int tvPrice = 900, dvdPrice = 500, mp3Price = 700;
            int tvTotal, dvdTotal, mp3Total;
            double discount;

            Console.Write("Enter Quantity for TV :");
            int tvQty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Quantity for DVD :");
            int dvdQty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Quantity for MP3 :");
            int mp3Qty = Convert.ToInt32(Console.ReadLine());

            tvTotal = tvPrice * tvQty;
            dvdTotal = dvdPrice * dvdQty;
            mp3Total = mp3Price * mp3Qty;
            double total = Convert.ToDouble(tvTotal + dvdTotal + mp3Total);

            if (total < 10000 && total > 5000)
            {

                discount = (((tvTotal + dvdTotal) * 10) / 100);
                total -= discount;

            }
            else if (total > 10000)
            {
                discount = (((tvTotal + dvdTotal) * 15) / 100);
                total -= discount;
            }

            Console.WriteLine("Total Price for this order is {0:C}", total);
            Console.ReadLine();

        }
    }
}
