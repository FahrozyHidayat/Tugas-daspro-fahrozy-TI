using System;

namespace DasarProg
{
    class Program
    {
        /*
        Program ini dibuat oleh
        Nama : Fahrozy Hidayat
        NIM : 2207112592
        Prodi : Teknik Informatika - A
        */

        static void Main(string[] args)
        {
            int kodeA;
            int kodeB;
            int kodeC;
            int jumlahKode;
            String tebakanA;
            String tebakanB;
            String tebakanC;

            kodeA = 2;
            kodeB = 4;
            kodeC = 8;

            int hasilTambah;
            int hasilKali;

            jumlahKode = 3;
            hasilTambah = kodeA+kodeB+kodeC;
            hasilKali = kodeA*kodeB*kodeC;

            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server...");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("Password terdiri dari "+jumlahKode+" angka");
            Console.WriteLine("Jika Ditambahkan hasilnya "+hasilTambah);
            Console.WriteLine("Jika Dikalikan hasilnya "+hasilKali);

            Console.Write("Masukkan Kode 1 : ");
            tebakanA = Console.ReadLine();
            Console.Write("Masukkan Kode 2 : ");
            tebakanB = Console.ReadLine();
            Console.Write("Masukkan Kode 3 : ");
            tebakanC = Console.ReadLine();

            Console.WriteLine("Tebakan Anda : "+ tebakanA +" "+tebakanB+" "+tebakanC+" ?");

            if (tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString())
            {
                Console.WriteLine("Tebakan Anda Benar!");
            }else{
                Console.WriteLine("Tebakan Anda Salah!");
            }

        }
    }
}
