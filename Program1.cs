using System;

namespace q1_RectangularArray
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int j = Convert.ToInt32(Console.ReadLine());
            int[,] ar = new int[j, j];
            int i, k;
            ar = GetArray(j);

            for (i = 0; i < j; i++)
            {
                for (k = 0; k < j; k++)
                {
                    Console.Write(ar[i, k] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int[,] GetArray(int a)
        {
            int[,] arr = new int[a, a];
            int m, n;
            for (m = 0; m < a; m++)
            {

                for (n = 0; n < a; n++)
                {
                    if (m == n)
                    {
                        arr[m, n] = 0;
                    }
                    else if (m < n)
                    {
                        arr[m, n] = 1;
                    }
                    else
                    {
                        arr[m, n] = -1;
                    }


                }
            }
            return arr;



        }
    }
}