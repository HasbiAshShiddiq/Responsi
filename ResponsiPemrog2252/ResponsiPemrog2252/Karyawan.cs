using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2252
{
    class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        
        

        

        public Karyawan (string Nik, string Nama, int GajiBulanan)
        {
            this.Nik = Nik;
            this.Nama = Nama;
            this.GajiBulanan = GajiBulanan;
        }
        public void NaikGaji()
        {
            GajiBulanan = GajiBulanan + GajiBulanan / 10;
        }
    }
}
