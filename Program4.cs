using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4_DesignTheDisplay
{
    public class Program4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Company Name");
            string comname = Console.ReadLine();
            Console.WriteLine("Enter the Employee Name");
            string empname = Console.ReadLine();
            Console.WriteLine("Enter the Project Name");
            string projname = Console.ReadLine();
            Console.WriteLine("Enter the Year");
            int year = Convert.ToInt32(Console.ReadLine());
            entireMessage(comname, empname, projname, year);

        }
        public static void HeaderMessage(string companyname)
        {
            Console.WriteLine(companyname + " Employee Information");
        }
        public static void FooterMessage(int year)
        {
            Console.WriteLine("Copyright " + year);
            Console.WriteLine("All Rights Reserved.");
        }
        public static void entireMessage(string comname, string empname, string projname , int year)
        {
            HeaderMessage(comname);
            Console.WriteLine(empname);
            Console.WriteLine(projname);
            FooterMessage(year);

        }

    }

}