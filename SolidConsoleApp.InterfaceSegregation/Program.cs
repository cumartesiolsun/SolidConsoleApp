using System;

namespace SolidConsoleApp.InterfaceSegregation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }

    internal interface ICalisan
    {
        void Calisir();
    }

    internal interface IYemekYiyen
    {
        void YemekYe();
    }

    internal class Calisan : ICalisan, IYemekYiyen
    {
        public void Calisir()
        {
            Console.WriteLine("Az yemek yendi");
        }

        public void YemekYe()
        {
            Console.WriteLine("Az çalıştı");
        }
    }

    internal class SuperCalisan : ICalisan, IYemekYiyen
    {
        public void Calisir()
        {
            Console.WriteLine("Çok yemek yendi");
        }

        public void YemekYe()
        {
            Console.WriteLine("Çok çalıştı");
        }
    }

    internal class Robot : ICalisan
    {
        public void Calisir()
        {
            throw new NotImplementedException();
        }
    }
}