using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Lab_9.ClassInduk;

namespace Tugas_Lab_9.ClassAnak
{
    class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }

        public override double Gaji()
        {
            return GajiBulanan;
        }

        public override string jenis()
        {
            return ("Karyawan Tetap ");
        }
    }
}