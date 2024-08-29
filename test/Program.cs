using test;
using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(Addnumber);
            myThread.Start();

            Thread myThread2 = new Thread(MinusNumber);
            myThread2.Start();

            Thread myThread3 = new Thread(ExtraNumber);
            myThread3.Start();

            Thread myThread4 = new Thread(BolishNumber);
            myThread4.Start();

            Thread myThread5 = new Thread(FoizNumber); 
            myThread5.Start();

        }
        public static void Addnumber() 
        {
            Console.WriteLine(1 + 2);
        }

        public static void MinusNumber()
        {
            Console.WriteLine(10 - 2);
        }

        public static void ExtraNumber()
        {
            Console.WriteLine(1 * 2);
        }

        public static void BolishNumber()
        {
            Console.WriteLine(1 / 2);
        }

        public static void FoizNumber()
        {
            Console.WriteLine(1 % 2);
        }

    }

}
