using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int Gaji { get; set; }

        public Karyawan(string Nik, string Nama, int Gaji)
        {
            this.Nik = Nik;
            this.Nama = Nama;
            this.Gaji = Gaji;
        }
        public void Bonus()
        {
            Gaji = Gaji + Gaji / 10;
        }

    }
}
