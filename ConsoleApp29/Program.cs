    using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp29
{
    internal class Program
    {
        #region Первое Задание : 
        class Kniga : IDisposable
        {
            public string Imya { get; set; }
            public string Avtor { get; set; }
            public string Tip { get; set; }
            public int God { get; set; }
            public Kniga() { }
            public Kniga(string imya, string avtor, string tip, int god)
            {
                Imya = imya;
                Avtor = avtor;
                Tip = tip;
                God = god;
            }
            public override string ToString()
            {
                return "Book" +Imya +"\nAvtor"+Avtor+"\nGenre"+Tip +"\nGod" + God;
            }
            ~Kniga() => Console.WriteLine($"Book finalizer called{Imya}");
            public void Dispose() => Console.WriteLine($"Called Dispose for book{Imya}");
        }
        #endregion

        #region Второе Задание : 
        public enum Shop
        {
            Продовольственный,
            Хозяйственный,
            Одежда,
            Обувь
        }

        public class Magazin : IDisposable
        {
            public string Imya { get; set; }
            public string Adres { get; set; }
            public Shop Tip_Magazin { get; set; }
            public Magazin() { }
            public Magazin(string imya, string adres, Shop tip_magazina)
            {
                Imya = imya;
                Adres = adres;
                Tip_Magazin = tip_magazina;
            }
            public override string ToString()
            {
                return $"Magazin{Imya}\nAdres{Adres}\nTip{Tip_Magazin}";
            }
            public void Dispose() => Console.WriteLine($"Called Dispose for the store{Imya}");
            ~Magazin() => Console.WriteLine($"Store finalizer called{Imya}");
        }
        #endregion
        static void Main(string[] args)
        {
            Kniga kniga = new Kniga("Pole_Chydes", "Mr.Gebit", "Horor", 2010);
            Console.WriteLine(kniga.ToString());
            using (kniga);
            Magazin shop = new Magazin("Afiny", "Sadovaya", Shop.Хозяйственный);
            Console.WriteLine(shop.ToString());
            using (shop);
        }
    }
}