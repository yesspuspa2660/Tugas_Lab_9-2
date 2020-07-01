using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Lab_9.ClassInduk;

namespace Tugas_Lab_9.ClassAnak
{
    class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }

        public override double Gaji()
        {
            return (JumlahPenjualan * Komisi);
        }

        public override string jenis()
        {
            return ("Sales ");
        }
    }
}