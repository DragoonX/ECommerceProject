using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Cevap
            RepeatN("İsim", "Soyisim", 4);
            Console.WriteLine();

            //2. Cevap
            orderArray(new int[] { 12,22,45,-13 });
            Console.WriteLine();

            //3. Cevap
            revStr("DenemeCümle");
            Console.WriteLine();

            //4. Cevap
            arrlist(new int[] {11,22,41,1234,123,11,234,55 });
            Console.WriteLine();

            //5. Cevap
            days();

            //6. Cevap
        }

        public static void RepeatN(string ad, string soyad, int say)
        {
            for (int i = 0; i < say; i++)
            {
                Console.Write(ad + " " + soyad + " ");
            }
        }
        public static void orderArray(int[] dizi)
        {
            Array.Sort(dizi);
            foreach (var i in dizi)
            {
                Console.Write(i+" ");
            }
        }

        public static void revStr(string a)
        {
            char[] x = a.ToCharArray();
            string reverse = String.Empty;
            for (int i = x.Length - 1; i > -1; i--)
            {
                reverse += x[i];
            }
            Console.Write(reverse);
        }

        public static void arrlist(int[] arr)
        {
            Console.Write(arr[0]+","+arr[1] + "," + arr[arr.Length-2] + ","+ arr[arr.Length - 1]);
        }

        public static void days()
        {
            DateTime now = DateTime.Today;

            for (int i = 0; i < 7; i++)
            {
                if (now == DateTime.Today)
                    Console.Write("BUGÜN ");
                else
                    Console.Write(now.ToString("dddd") + " ");
                now = now.AddDays(1);
            }

        }
    }
}
/*
    1. Adınızı ve soyadınızı N kere yazdıracak bir method gelitiştirin. => RepeatNTimes("isim","soyisim",4)
    Output: isim soyisim isim soyisim isim soyisim isim soyisim

    2. Int array listesini küçükten büyüğe sıralayın.
    orderArray(23,2323,43,4,12,212,0,-2,-3,-123123)
    output : sıralı olacak

    3. Stringi ters yazdırın

    4. Array listteki ilk 2 ve son 2 elemanı alıp yeni bir arraylist oluşturun.

    5. Haftanın bütün günlerini yazdırın. Bugün günlerden ne ise o güne BUGÜN yazdırın.

    6. Array deki en büyük ve en küçük sayıyı döndürün.
     */
