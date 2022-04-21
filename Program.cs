using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4469
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan();
          


            Console.WriteLine("No Nik/Nama                      Gaji Bulanan");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1. {0}", karyawan.Nik(190302123), ". {1}", karyawan.Nama("Paijo"), ".                      {2}", karyawan.GajiBulanan(3000000));
            Console.WriteLine("2. {0}", karyawan.Nik(190302124), ". {1}", karyawan.Nama("Jono"), ".                       {2}", karyawan.GajiBulanan(2000000));
            Console.WriteLine("Asyiiiiiik  kenaikan gaji 10% !!");

            Console.WriteLine("No Nik/Nama                      Gaji Bulanan");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1. {0}", karyawan.Nik(190302123), ".  \t{1}", karyawan.Nama("Paijo"), ".                       {2}", karyawan.GajiBulanan(3000000) + karyawan.GajiBulanan(3000000 * 0.1));
            Console.WriteLine("2. {0}", karyawan.Nik(190302124), ".  \t{1}", karyawan.Nama("Jono"), ".                        {2}", karyawan.GajiBulanan(2000000) + karyawan.GajiBulanan(2000000 * 0.1));

            Console.ReadKey();
        }
    }
    
}
