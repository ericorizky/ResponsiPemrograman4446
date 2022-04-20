using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4452
{
    internal class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public float Gajibulanan { get; set; }
        public Karyawan(string Nik, string nama, float gaji)
        {
            this.Nik = Nik;
            this.Nama = nama;
            if (gaji < 0)
            {
                gaji = 0;
            }
            this.Gajibulanan = gaji;
        }

        public void NaikkanGaji(float persentase)
        {
            this.Gajibulanan = persentase / 100 * this.Gajibulanan + this.Gajibulanan;
        }

    }
}