using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Lab_9.ClassInduk;

namespace Tugas_Lab_9.ClassAnak
{
    public class KaryawanHarian : Karyawan
    {
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }

        public override double Gaji()
        {
            return (UpahPerJam * JumlahJamKerja);
        }

        public override string jenis()
        {
            return ("Karyawan Harian ");
        }
    }
}