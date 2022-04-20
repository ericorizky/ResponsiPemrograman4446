using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4452
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("12345", "Erico", 2000000);
            Karyawan karyawan2 = new Karyawan("67890", "Rizky", 3000000);
            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", karyawan1.Nik, karyawan1.Nama, karyawan1.Gajibulanan);
            Console.WriteLine("2    {0}/{1}         {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.Gajibulanan);

            Console.WriteLine();
            Console.WriteLine("Asyiiik kenaikan gaji sebesar 10% !!");
            Console.WriteLine();

            karyawan1.NaikkanGaji(10);
            karyawan2.NaikkanGaji(10);

            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", karyawan1.Nik, karyawan1.Nama, karyawan1.Gajibulanan);
            Console.WriteLine("2    {0}/{1}         {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.Gajibulanan);

            Console.ReadKey();
        }
    }
}