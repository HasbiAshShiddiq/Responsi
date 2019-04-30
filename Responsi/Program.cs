using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan Kar1 = new Karyawan("19030123", "Jono", 3000000);
            Karyawan Kar2 = new Karyawan("19030123", "Paijo", 4000000);

            if(Kar1.Gaji<=0)
            {
                Kar1.Gaji = 0;
            }
            else if(Kar1.Gaji>=0)
            {
                Kar1.Gaji = Kar1.Gaji;
            }
            Console.WriteLine("No. Nik/Nama                    Gaji");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. {0}/{1}         Rp.{2}", Kar1.Nik, Kar1.Nama, Kar1.Gaji);
            Console.WriteLine("2. {0}/{1}        Rp.{2}", Kar2.Nik, Kar2.Nama, Kar2.Gaji);

            Console.WriteLine();
            Console.WriteLine();

            Kar1.Bonus();
            Kar2.Bonus();

            Console.WriteLine("No. Nik/Nama                    Gaji");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. {0}/{1}         Rp.{2}", Kar1.Nik, Kar1.Nama, Kar1.Gaji);
            Console.WriteLine("2. {0}/{1}        Rp.{2}", Kar2.Nik, Kar2.Nama, Kar2.Gaji);
        }
    }
}
