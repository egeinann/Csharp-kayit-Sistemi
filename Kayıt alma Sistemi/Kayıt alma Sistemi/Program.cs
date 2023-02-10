using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kayıt_alma_Sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adsoyad, eposta, telefon, sifre1, sifre2; // kayıt sf. değişkenleri
            int a, kod; // doğrulama kodu değişkenleri
            string grsposta,grssifre; // giriş sf. değişkenleri

            Console.WriteLine("--------------- Kayıt Register ---------------\n"); // Kayıt sf.başlık
            Console.Write("Ad Soyad : "); // ad soyad giriş
            adsoyad = Console.ReadLine();
            Console.Write("E-posta : "); // e-posta giriş
            eposta = Console.ReadLine();
            Console.Write("Telefon NO ( XXX XXX XXXX şeklinde ) giriniz : +90 0"); // telNO giriş
            telefon = Console.ReadLine();
            while(telefon.Length!=12) // TelNO yanlış mı girildi... doğru girilene kadar döndür
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.Write("HATALI Telefon NO (XXX XXX XXXX şeklinde ) giriniz : +90 0");
                telefon = Console.ReadLine();
                if(telefon.Length==12) // doğru girildi... çık doğrulama kodu kısmına geç
                {
                    break; // çık
                }
            }
            Random rastgele = new Random();
            a = rastgele.Next(1111, 9999); // arasında rastgele doğrulama kodu oluştur
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nDoğrulama kodu : " + a); // oluşan kodu kullanıcıya göster
            Console.ForegroundColor=ConsoleColor.White;
            Console.Write("Kodu giriniz : "); // kodu iste
            kod = Convert.ToInt32(Console.ReadLine());           
            while (kod != a) // kod yanlış olduğu sürece tekrar iste
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.Write("HATALI GİRİŞ !!! Kodu giriniz : ");
                kod = Convert.ToInt32(Console.ReadLine());
                if (kod == a) // kod doğru mu ? doğru... içeri gir
                {
                    break; // döngüden çık
                }
            }
            Console.ForegroundColor= ConsoleColor.White;
            Console.Write("\nŞifre oluştur : "); // sifre oluştur
            sifre1= Console.ReadLine();
            while(sifre1.Length<8) // şifre 8 karakterden az ise sürekli iste
            {
                Console.ForegroundColor=ConsoleColor.Red;
                Console.Write("En az 8 karakter kullanınız !!! Şifre oluştur : ");
                sifre1 = Console.ReadLine();
                if(sifre1.Length>=8) // 8 karakter veya fazlası mı ?... çık
                {
                    break; // çık
                }
            }
            Console.ForegroundColor= ConsoleColor.White;
            Console.Write("\nŞifre tekrar : "); // tekrar yaz aynısı olsun
            sifre2= Console.ReadLine();
            if(sifre1 != sifre2) // şifreler farklı olamaz döngüye gir
            {
                while(sifre1!= sifre2) // aynı olmadığı sürece dön
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Girilen şifreler aynı değil !!! şifre tekrar :");
                    sifre2 = Console.ReadLine();
                    if(sifre1==sifre2) // aynı ise çık
                    {
                        break; // çık
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nKAYIT OLDUNUZ giriş sekmesine gitmek için Enter tuşlayınız.");
            Console.ReadLine();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------- Giriş LogIn ---------------\n"); // Giriş sf. başlık
            Console.Write("E-Posta : "); // e-posta gir
            grsposta= Console.ReadLine();
            while(grsposta!=eposta) // kayıt alanındaki ile aynı değil ise döndür
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Adınıza kayıt bulunmamaktadır. E-Posta : ");
                grsposta = Console.ReadLine();
                if(grsposta==eposta) // aynı girildiyse çık
                {
                    break; // çık
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Şifre : "); // şifre gir
            grssifre= Console.ReadLine();
            while (grssifre!=sifre2) // kayıt alanındaki ile aynı değil ise döndür 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Şifreniz HATALI !!! Şifre : ");
                grssifre = Console.ReadLine();
                if (grssifre==sifre2) // aynı girildiyse çık
                {
                    break; // çık
                }
            }
            Console.BackgroundColor= ConsoleColor.DarkGreen;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("\n* * * * * * * * * * * * * * *\n\nGİRİŞ BAŞARILI\n\n* * * * * * * * * * * * * * *");


            Console.Read();
        }
    }
}
