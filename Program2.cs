using System;

namespace q2_ClearanceSale
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name of the Product");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Price of the Product");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is the product on SALE (yes/no) : ");
            string dec = Console.ReadLine();
            Console.WriteLine("Enter number of product sold in day 1  ");
            int day1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of product sold in day 2  ");
            int day2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of product sold in day 3  ");
            int day3 = Convert.ToInt32(Console.ReadLine());
            float s1, s2, s3, total1, total2, total3;
            float dis1, dis2, dis3;
            if (dec == "yes")
            {
                dis1 = price * 7 / 100;
                s1 = price - dis1;
                dis2 = s1 * 7 / 100;
                s2 = s1 - dis2;
                dis3 = s2 * 7 / 100;
                s3 = s2 - dis3;
                total1 = s1 * day1;
                total2 = s2 * day2;
                total3 = s3 * day3;
                Console.WriteLine($"{name}");
                Console.WriteLine($"Day 1 sales total : {total1} ");
                Console.WriteLine($"Day 2 sales total : {total2} ");
                Console.WriteLine($"Day 3 sales total : {total3} ");
            }
            else
            {
                total1 = day1 * price;
                total2 = day2 * price;
                total3 = day3 * price;
                Console.WriteLine($"{name}");
                Console.WriteLine($"Day 1 sales total : {total1} ");
                Console.WriteLine($"Day 2 sales total : {total2} ");
                Console.WriteLine($"Day 3 sales total : {total3} ");

            }


        }
    }
}
