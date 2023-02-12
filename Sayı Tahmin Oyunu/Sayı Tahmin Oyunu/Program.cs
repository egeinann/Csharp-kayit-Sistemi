using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayı_Tahmin_Oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- SAYI TAHMİN OYUNU ----------\n1-100 arası\n");
            int tahmin = 0;
            int hafiza;
            int sayac = 0;
            Random rastgele=new Random();
            hafiza = rastgele.Next(1, 101); // 1 dahil - 101 dehil değil !!!
            while(tahmin!=hafiza) // eğer tahmin farklıysa hafızadaki sayıdan... bilene kadar içerideki işlemleri döndür
            {
                sayac++; // tahmin farklıysa (yanlışsa) sayacı 1 arttır.
                Console.Write("Sayı girin : ");
                tahmin = Convert.ToInt16(Console.ReadLine());
                if(tahmin > hafiza)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nSayıyı AZALT !!!");
                }
                else if(tahmin < hafiza)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nSayıyı ARTTIR !!!");
                }
            }
            
            Console.BackgroundColor= ConsoleColor.Green;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("\nTEBRİKLER SAYI BULUNDU\n");
            Console.WriteLine("Hafızada tutulan sayı {0}" , hafiza);
            Console.WriteLine("{0}. denemede bulundu.",sayac);
            Console.WriteLine("\nÇıkış yapmak için Enter'a basınız.");

            Console.Read();
        }
    }
}
