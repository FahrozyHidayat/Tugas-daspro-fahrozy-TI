using System;

namespace Soal2UTS
{
    class Program
    {
        static void Main(string[] args){
            int tebakan;
            int rng;
            int minimal = 1;
            int maksimal = 100;
            Random random = new Random();
            bool main = true;
            while (main){
                tebakan = 0;
                rng = random.Next(minimal, maksimal + 1);

                while (tebakan != rng){
                    Console.Write("Tebak angka antara "+minimal+"-"+maksimal+" : ");
                    tebakan = Convert.ToInt32(Console.ReadLine());

                    if (tebakan > rng){
                        Console.WriteLine("Salah. Nilai terlalu tinggi.");
                    }
                    else if (tebakan < rng){
                        Console.WriteLine("Salah. Nilai terlalu rendah.");
                    }
                }
                Console.WriteLine("Anda benar!");
                Console.WriteLine("Bye...");
                break;
            }
        }
    }
}