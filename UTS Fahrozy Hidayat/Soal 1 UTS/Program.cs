using System;

//Dosen Pengampu: Rahmat Rizal Andhi, S.T., M.T.
//Nama : Fahrozy Hidayat
//NIM : 2207112592
//Kelas : TI-A

namespace Soal1UTS{
    class Program{
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Nama         : ");
            string nama = Console.ReadLine();
            Console.Write("NIM          : ");
            string nim = Console.ReadLine();
            Console.Write("Konsentrasi  : ");
            string konsentrasi = Console.ReadLine();
            mahasiswaTI mahasiswaTIFull = new mahasiswaTI(nama, nim, konsentrasi);
            mahasiswaTIFull.printNameTag();
        }
    }
    class mahasiswaTI
    {
        string nama;
        string nim;
        string konsentrasi;

        public mahasiswaTI(string Nama, string NIM, string Konsentrasi)
        {
            nama = Nama;
            nim = NIM;
            konsentrasi = Konsentrasi;
        }
        public void printNameTag()
        {
            Console.WriteLine("|************************|");
            Console.WriteLine("|Nama:{0,19}|",nama);
            Console.WriteLine("|              {0,10}|",nim);
            Console.WriteLine("|------------------------|");
            Console.WriteLine("|      {0,18}|",konsentrasi);
            Console.WriteLine("|************************|");
        }
    }
}