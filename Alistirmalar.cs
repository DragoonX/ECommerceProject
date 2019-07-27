using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RepeatN("Anılcan","Şaşkın",4);


            //int[] cx = new int[] { 12,22,45,-13};
            //orderArray(cx);

            Console.WriteLine();
            revStr("Transatlantik");

            //arrlist(new int[] {11,22,41,1234,123,11,234,55 });

            days();

            Console.Read();
        }

        public static void RepeatN(string ad, string soyad, int say)
        {
            for(int i = 0; i < say; i++)
            {
                Console.Write(ad + " " + soyad + " ");
            }
        }
        public static void orderArray(int[] dizi)
        {
            int x = 0;
            for (int y = 0; y < dizi.Length; y++)
            {
                if (dizi[y]< dizi[y+1])
                {
                    x = dizi[y];
                    dizi[y] = dizi[y + 1];
                    dizi[y + 1] = x;
                }
            }
            Console.WriteLine(dizi);
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
            int[] newarr = new int[] { };

            newarr[0] = arr[0];
            newarr[1] = arr[1];
            newarr[2] = arr[arr.Length - 1];
            newarr[3] = arr[arr.Length];

            Console.WriteLine(newarr);
        }

        public static void days()
        {
            DayOfWeek today = DateTime.Today.DayOfWeek;
        Console.WriteLine("Today is {0}",
            today);

        // Test current day of week.
        if (today == DayOfWeek.Monday)
        {
            Console.WriteLine("DO WORK");
        }

        // Demonstrate all DayOfWeek values.
        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}",
            DayOfWeek.Monday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
            DayOfWeek.Friday,
            DayOfWeek.Saturday,
            DayOfWeek.Sunday);

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
