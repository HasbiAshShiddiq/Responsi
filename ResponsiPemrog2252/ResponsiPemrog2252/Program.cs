using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2252
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan Kar1 = new Karyawan("19030123", "Paijo", 300000);
            Karyawan Kar2 = new Karyawan("19030124", "Jono", 200000);


            Console.WriteLine("No Nik/Nama                  Gaji Bulanan");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1. {0} {1} {2}", Kar1.Nik, Kar1.Nama, Kar1.GajiBulanan);
            Console.WriteLine("2. {0} {1} {2}", Kar2.Nik, Kar2.Nama, Kar2.GajiBulanan);

            Console.WriteLine();
            Console.WriteLine();

            Kar1.NaikGaji();
            Kar2.NaikGaji();

            Console.WriteLine("No Nik/Nama                  Gaji Bulanan");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1. {0} {1} {2}", Kar1.Nik, Kar1.Nama, Kar1.GajiBulanan);
            Console.WriteLine("2. {0} {1} {2}", Kar2.Nik, Kar2.Nama, Kar2.GajiBulanan);

        }
    }
}
