using System;


namespace q5_PayCalculation		
{
    public class Program5        
    {
        public static void Main(string[] args)      
        {
           
            Console.WriteLine("Enter the number of hours worked");
            int hrsWorked = int.Parse(Console.ReadLine());

            Console.WriteLine($"The calculated Net pay is ${CalculateNetPay(hrsWorked)}");
        }

       
        public static double GetGrossPay(int hrsWorked)
        {
            double grossPay;

            if (hrsWorked < 56)
                grossPay = hrsWorked * 80;
            else
            {
                int extraHours = hrsWorked - 56;
                grossPay = (extraHours * 1.5 * 80) + (hrsWorked * 80);
            }

            return grossPay;
        }

        public static double CalculateTax(double grossPay)
        {
            double deductTax;

            deductTax = grossPay * 0.02;

            return deductTax;
        }

        public static double CalculateNetPay(int hrsWorked)
        {
            double netPay, grossPay, deductTax;

            grossPay = GetGrossPay(hrsWorked);
            deductTax = CalculateTax(grossPay);
            netPay = grossPay - deductTax;

            return netPay;
        }
    }
}