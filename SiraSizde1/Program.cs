using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiraSizde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ekranİslem ekranİslem = new Ekranİslem();
            ekranİslem.EkranaYaz(0);
            Console.WriteLine("=======================");
            ekranİslem.EkranaYaz();
        }
        class Ekranİslem
        {
            public void EkranaYaz(params int[] sayilar)
            {
                if (sayilar.Length == 0)
                {
                    Console.WriteLine("Parametreden çıkılıyor");
                    return;
                }
                Console.WriteLine("Parametreden gelen değer: ");
                foreach (var s in sayilar)
                {
                    if (s == 0) return;
                    Console.WriteLine(s);
                }
            }
        }
    }
}
