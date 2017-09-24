using System;

namespace SolidConsoleApp.DependencyInversion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MakaleManager makaleManager = new MakaleManager(new NHMakaleDal());
            makaleManager.Ekle();

            Console.ReadKey();
        }
    }

    internal interface IMakaleDal
    {
        void Ekle(Makale makale);
    }

    public class Makale
    {
    }

    internal class EfMakaleDal : IMakaleDal
    {
        public void Ekle(Makale makale)
        {
            Console.WriteLine("EF kullanılarak makale eklendi.");
        }
    }

    internal class NHMakaleDal : IMakaleDal
    {
        public void Ekle(Makale makale)
        {
            Console.WriteLine("NHibernate kullanılarak makale eklendi.");
        }
    }

    internal class MakaleManager
    {
        private IMakaleDal _makaleDal;

        public MakaleManager(IMakaleDal makaleDal)
        {
            _makaleDal = makaleDal;
        }

        public void Ekle()
        {
            _makaleDal.Ekle(new Makale());
        }
    }
}