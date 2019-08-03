using System;

namespace Exercises3
{
    class Program
    {
        static void Main(string[] args)
        {
            //repStr("Ali ata bak.");
            //Console.WriteLine();
            revstr("Hercules.");
            Console.WriteLine();
            countStr("Ali ata bak.");
            Console.WriteLine();
            replaceStr("Ali ata bak.");
            Console.WriteLine();
            bubSort(new int[] { 5,1,4,2,8});
            Console.Read();
        }

        //Bir stringde yinelenen karakterleri yazın?
        public static void repStr(string s)
        {
            string s2 = s.Replace(" ","");
            for (int i = 0; i < s.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s2[i] == s2[j])
                    {
                        count++;
                    }
                    Console.Write(s2[i] + ":" + count);
                }
            }
        }

        // String reverse komutu kullanmadan stringi ters çevir.
        public static void revstr(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[s.Length - i - 1]);
            }
        }
        //stringde boşluk yerine tire koy
        public static void replaceStr(string x)
        {
            string x2 = x.Replace(" ", "-");
            Console.WriteLine(x2);
        }

        //Stringdeki kelime sayısını yazdırın.
        public static void countStr(string x)
        {
            int x2 = x.Split(" ").Length;
            Console.WriteLine(x2);
        }
        //bubble sort fonksiyonu yazınız.
        public static void bubSort(int[] dizi)
        {
            int tmp;
            for (int i = 0; i < dizi.Length-1; i++)
            {
                for (int j = 0; j < dizi.Length - 1; j++)
                {
                    if (dizi[j] > dizi[j+1])
                    {
                        tmp = dizi[j];
                        dizi[j] = dizi[j + 1];
                        dizi[j+1] = tmp;
                    }
                }
            }

            foreach (var item in dizi)
            {
                Console.Write(item);
            }
        }

        //stringte tekrar eden karakterleri çıkartın
        //iki stringin birbirinin anagramı olup olmadığını kontrol edin.
        //stringdeki karakterlerin birbirlerinden benzersiz olduğunu doğrulayın.
        //2 integer Array deki sayıları ayrıayrı toplayın, array toplamlarının birbirinden çıkartın
        //interger array deki sıfırları array in sonuna taşıyın
        //geçici değişken kullanmadan 2 numerik değeri birbirleri ile yer değiştirin.
    }
}
