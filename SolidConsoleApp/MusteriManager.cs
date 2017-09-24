using System;

namespace SolidConsoleApp
{
    [LoggingAspect]

    internal class MusteriManager
    {
        internal void Ekle(Musteri musteri)
        {
            //Veri erişim katmanına ekleme işlemleri
            Console.WriteLine("Veri tabanına eklendi");
        }

        internal void Sil(Musteri musteri)
        {
            //Veri erişim katmanına ekleme işlemleri
            Console.WriteLine("Veri tabanına silindi");
        }
    }
}
