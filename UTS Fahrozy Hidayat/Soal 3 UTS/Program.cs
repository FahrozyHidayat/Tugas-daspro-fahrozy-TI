using System;
 
namespace Soal3UTS
{
    class Program
    {
        static void Main(string[] args)
        {
            int hari;
            Console.Write("Input jumlah hari peminjaman : ");
            hari = int.Parse(Console.ReadLine());
            float denda = 0;
            if (hari <= 5)
            {
                denda = 0;
                Console.WriteLine("Total denda : Rp." + denda + "");
                Console.WriteLine();
            }
            else if (hari > 5 && hari <= 10)
            {
                denda = (hari - 5) * 10000;
                Console.WriteLine("Total denda : Rp." + denda + "");
                Console.WriteLine();
            }
            else if (hari > 10 && hari <= 30)
            {
                denda = 5 * 10000 + (hari - 10) * 20000;
                Console.WriteLine("Total denda : Rp." + denda + "");
                Console.WriteLine();
            }
            else
            {
                denda = 5 * 10000 + 20 * 20000 + (hari - 30) * 30000;
                Console.WriteLine("Keanggotaan anda dibatalkan.\nTotal denda : Rp." + denda + "");
                Console.WriteLine();
            }
        }
    }
}