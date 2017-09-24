using System;

namespace SolidConsoleApp.LiskovSubstitution
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            Console.WriteLine("dikdörtgen: {0}", dikdortgen.AlanHesapla(5, 10));

            Kare kare = new Kare();
            Console.WriteLine("kare: {0}", kare.AlanHesapla(5, 10));

            Kup kup = new Kup();
            Console.WriteLine("Kup: {0}", kup.AlanHesapla(5, 10, 5));

            Console.ReadLine();
        }
    }

    internal class Dikdortgen
    {
        public int AlanHesapla(int a, int b)
        {
            return a * b;
        }
    }

    internal class Kare : Dikdortgen
    {
    }

    internal class Kup : Dikdortgen
    {
        public int AlanHesapla(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}