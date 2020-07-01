using System;
using System.Collections;
using System.Collections.Generic;
using Tugas_Lab_9.ClassAnak;
using Tugas_Lab_9.ClassInduk;

namespace Tugas_Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 9";

            String kembali;
            int noUrut = 1;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            Sales sales = new Sales();

        menu:
            Console.Clear();
            Console.WriteLine(" DATA KARYAWAN PT.SUKAMAJU ");
            Console.WriteLine();
            Console.WriteLine(" 1. Tambah Data Karyawan");
            Console.WriteLine(" 2. Hapus Data Karyawan ");
            Console.WriteLine(" 3. Tampilkan Data Karyawan ");
            Console.WriteLine(" 4. Keluar ");
            Console.WriteLine();
            Console.Write(" Pilih Opsi diatas [1..4] : ");
            int opsi = Convert.ToInt32(Console.ReadLine());

            switch (opsi)
            {
                case 1:
                jenis:
                    Console.Clear();
                    Console.WriteLine(" Tambah Data Karyawan ");
                    Console.WriteLine();
                    Console.WriteLine(" Jenis Karyawan");
                    Console.WriteLine(" 1. Karyawan Harian");
                    Console.WriteLine(" 2. Karyawan Tetap ");
                    Console.WriteLine(" 3. Sales ");
                    Console.WriteLine(" 4. Kembali ");
                    Console.Write(" Pilih Opsi diatas [1..4] : ");
                    int pilih = Convert.ToInt32(Console.ReadLine());

                    switch (pilih)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine(" Karyawan Harian ");
                            Console.WriteLine();
                            Console.Write(" NIK \t: ");
                            karyawanHarian.Nik = Console.ReadLine();

                            Console.Write(" Nama \t: ");
                            karyawanHarian.Nama = Console.ReadLine();

                            Console.Write(" Jumlah Jamkerja : ");
                            karyawanHarian.JumlahJamKerja = Convert.ToInt32(Console.ReadLine());

                            Console.Write(" Upah per Jam \t: ");
                            karyawanHarian.UpahPerJam = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine(" Data Berhasil di Disimpan");

                            listKaryawan.Add(karyawanHarian);

                            Console.WriteLine();
                            Console.Write(" Tekan Enter Untuk Kembali ");
                            kembali = Console.ReadLine();
                            goto menu;

                        case 2:
                            Console.Clear();
                            Console.WriteLine(" Karyawan Tetap ");
                            Console.WriteLine();
                            Console.Write(" NIK :");
                            karyawanTetap.Nik = Console.ReadLine();

                            Console.Write(" Nama :");
                            karyawanTetap.Nama = Console.ReadLine();

                            Console.Write(" Gaji Bulanan :");
                            karyawanTetap.GajiBulanan = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine(" Data Berhasil di Disimpan");

                            listKaryawan.Add(karyawanTetap);

                            Console.WriteLine();
                            Console.Write(" Tekan Enter Untuk Kembali ");
                            kembali = Console.ReadLine();
                            goto menu;

                        case 3:
                            Console.Clear();
                            Console.WriteLine(" Sales ");
                            Console.WriteLine();
                            Console.Write(" NIK :");
                            sales.Nik = Console.ReadLine();

                            Console.Write(" Nama :");
                            sales.Nama = Console.ReadLine();

                            Console.Write(" Jumlah Penjualan : ");
                            sales.JumlahPenjualan = Convert.ToInt32(Console.ReadLine());

                            Console.Write(" Komisi :");
                            sales.Komisi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine(" Data Berhasil di Disimpan");

                            listKaryawan.Add(sales);

                            Console.WriteLine();
                            Console.Write(" Tekan Enter Untuk Kembali ");
                            kembali = Console.ReadLine();
                            goto menu;

                        case 4:
                            goto menu;

                        default:
                            Console.Clear();
                            Console.Write(" Inputan yang anda Pilih tidak ada, Coba Ulangi ");
                            kembali = Console.ReadLine();
                            goto jenis;
                    }

                case 2:
                    Console.Clear();
                    Console.WriteLine(" Hapus Data Karyawan ");

                    Console.WriteLine();
                    Console.Write(" Masukan Nik Data Yang Mau dihapus : ");
                    string nik = Console.ReadLine();

                    for (int i = 0; i < listKaryawan.Count; i++)
                    {
                        if (listKaryawan[i].Nik == nik)
                        {
                            listKaryawan.Remove(listKaryawan[i]);
                            Console.WriteLine(" Data Berhasil di Hapus");
                        }
                        else
                        {
                            Console.WriteLine(" Nik Tidak di Temukan ");
                        }
                    }

                    Console.WriteLine();
                    Console.Write(" Tekan Enter Untuk Kembali ");
                    kembali = Console.ReadLine();
                    goto menu;

                case 3:
                    Console.Clear();
                    Console.WriteLine(" Tampil Data Karyawan ");
                    Console.WriteLine();


                    foreach (Karyawan karyawan in listKaryawan)
                    {
                        Console.WriteLine(" {0}, Nik: {1}, Nama: {2}, Gaji: {3:n0}, {4}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji(), karyawan.jenis());

                        noUrut++;
                    }

                    Console.WriteLine();
                    Console.Write(" Tekan Enter Untuk Kembali ");
                    kembali = Console.ReadLine();
                    goto menu;

                case 4:
                    Environment.Exit(1);
                    break;

                default:
                    Console.Clear();
                    Console.Write(" Inputan yang anda Pilih tidak ada, klik Enter untuk Kembali ");
                    kembali = Console.ReadLine();
                    goto menu;
            }

        }
    }
}