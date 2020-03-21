using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.nama = "Supir";
            taxi.posisi = true;
            taxi.nopenumpang = 10;

            taxi.info();
            taxi.menjemput();
            taxi.sampai();

            Console.ReadKey();
        }
        public class Taxi
        {
            public string nama { get; set; }
            public bool posisi { get; set; }
            public int nopenumpang { get; set; }

            public void info()
            {
                Console.WriteLine("Nama Driver : {0}", nama);
                if (posisi)
                    Console.WriteLine("Di Perjalanan : YES");
                else
                    Console.WriteLine("Di Perjalanan : NO");
                Console.WriteLine("Nomor Penumpang : {0}", nopenumpang);
            }
            public void menjemput()
            {
                if (posisi)
                    Console.WriteLine("{0} sedang menjemput penumpang", nama);
                else
                    Console.WriteLine("{0} tidak sedang menjemput penumpang", nama);
            }
            public void sampai()
            {
                if (posisi)
                    Console.WriteLine("{0} selesai mengantar penumpang", nama);
                else
                    Console.WriteLine("{0} belum selesai mengantar penumpang", nama);
            }
        }
    }
}
