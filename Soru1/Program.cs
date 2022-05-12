using System;
//ER3N
namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad;
            int num;

            Console.Write("   Adınız: ");
            ad = Console.ReadLine();
            Console.Write("Soyadınız: ");
            soyad = Console.ReadLine();
            Console.Write("       NO: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("   Adınız: " + ad);
            Console.WriteLine("Soyadınız: " + soyad);
            Console.WriteLine("       NO: " + num);
            Console.WriteLine();
            Console.WriteLine("HOŞGELDİNİZ " + num + " NUMARALI " + ad + " " + soyad);

        }
    }
}
