using System;

namespace Soal4UTS
{
    class Program
    {
        static void Main(string[] args)
        {

        string inputPemain, Computer;
        int rng;
        string loop;
        bool tetapBermain = true;
        string[] gerakanValid = new string[3] { "b", "g", "k" };
        int menang = 0;
        int kalah = 0;
        int seri = 0;
        while (tetapBermain)
            {
            Random RandomObjek = new Random();
            rng = RandomObjek.Next(1, 4);
            Console.Write("Choose [b]atu, [g]unting, [k]ertas, or [e]xit:");
            inputPemain = Console.ReadLine();

            if (inputPemain == "e")
            {
                break;
            }
            else if (!gerakanValid.Contains(inputPemain))
            {
                Console.WriteLine("Mohon masukkan input yang benar.");
                continue;
            }

            switch (rng)
            {
                case 1:
                    Computer = "Batu";
                    Console.WriteLine("Komputer memilih Batu");
                    if (inputPemain == "b")
                    {
                        Console.WriteLine("Seri.");
                        seri++;
                    }
                    else if (inputPemain == "k")
                    {
                        Console.WriteLine("Kamu menang!!");
                        menang++;
                    }
                    else if (inputPemain == "g")
                    {
                        Console.WriteLine("Komputer menang!!");
                        kalah++;
                    }
                    break;
                case 2:
                    Computer = "Kertas";
                    Console.WriteLine("Komputer memilih Kertas");
                    if (inputPemain == "k")
                    {
                        Console.WriteLine("Seri.");
                        seri++;
                    }
                    else if (inputPemain == "b")
                    {
                        Console.WriteLine("Komputer menang!!");
                        kalah++;
                    }
                    else if (inputPemain == "g")
                    {
                        Console.WriteLine("Kamu menang!!");
                        menang++;
                    }
                    break;
                case 3:
                    Computer = "Gunting";
                    Console.WriteLine("Komputer memilih Gunting");
                    if (inputPemain == "g")
                    {
                        Console.WriteLine("Seri.");
                        seri++;
                    }
                    else if (inputPemain == "b")
                    {
                        Console.WriteLine("Kamu menang.");
                        menang++;
                    }
                    else if (inputPemain == "k")
                    {
                        Console.WriteLine("Komputer menang!!");
                        kalah++;
                    }
                    break;
                default:
                    Console.WriteLine("Mohon masukkan input yang benar");
                    break;
            }

            Console.WriteLine("Skor: {0} menang:, {1} kalah:, {2} seri", menang, kalah, seri);

            Console.WriteLine("Tekan Enter untuk melanjutkan permainan...");
            loop = Console.ReadLine();
            
            if (loop == "")
            {
                tetapBermain = true;
            }
            else if (loop == "e")
            {
                tetapBermain = false;
            }
            }
        }
    }
}