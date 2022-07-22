using System;

namespace proje_odev // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç Adet sayı girmek istersin: ");
            var n = Convert.ToInt32(Console.ReadLine());

            {
                List<int> ciftSayilar = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi % 2 == 0)
                    {
                        ciftSayilar.Add(sayi);
                    }
                }

                foreach (var sayi in ciftSayilar)
                {
                    Console.Write(sayi + " ");
                }

            }
            Console.Read();
        }

    }
}