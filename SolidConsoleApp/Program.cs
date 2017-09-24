using System;

namespace SolidConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var musteriManager = new MusteriManager();

            musteriManager.Ekle(new Musteri { Id = 1, Adi = "İlker" });
            musteriManager.Sil(new Musteri { Id = 1, Adi = "İlker" });
            Console.WriteLine("Bitti");
            Console.ReadLine();
        }
    }
}