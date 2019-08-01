using System;

namespace AlgExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            KillCircle(100, 5);
            Console.WriteLine();
            findToday();
            Console.WriteLine();
            FindFibo(5);
            Console.WriteLine();
            KillCircle2(2, 6);
            Console.Read();
        }

        //Daire þeklinde bir masada baþlangýcý belli bir kiþi solundakini kýlýçla öldürüp saðýndakine silahý verir.
        //Bunu simüle ediniz?
        public static void KillCircle(int p, int startPoint)
        {
            int result = 0;
            result = startPoint - 2;

            if (result < 1)
            {
                result = result - p;
            }
            Console.WriteLine(result);
        }

        /*Bugünün yýlýn kaçýncý günüdür?.*/

        public static void findToday()
        {
            DateTime yilbasi = new DateTime(2019, 01, 01);
            DateTime bugun = DateTime.Now;
            Console.WriteLine((bugun.AddDays(1) - yilbasi).Days.ToString());
        }

        //5 basamaklý en küçük fibonacci sayýsýný bulunuz
        public static void FindFibo(int f)
        {
            int x = 0;
            int maks = Convert.ToInt32(Math.Pow(10, f - 1));
            for (int i = 0; i < maks; i++)
            {
                x = Fibonacci(i);
                if (x / (maks) == 1)
                {
                    Console.WriteLine(x);
                    break;
                }
            }
        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        //yuvarlak masada baþlangýç kiþi solundakine kýlýç verir ve bu kiþi solundakini öldürür, ardýndan kýlýcý saðýndakine verir ve bu kiþi de saðýndakini öldürür.
        public static void KillCircle2(int a, int b)
        {
            if ((b - a + 1) % 2 == 0)
            {
                Console.WriteLine(a);
            }
            else
                Console.WriteLine(b);
        }


    }
}
