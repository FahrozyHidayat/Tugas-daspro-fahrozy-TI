using System;

//Tugas Daspro : Game Dadu (Oleh Fahrozy Hidayat)

namespace DaduDasPro
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            int[] d1=new int[3];
            int[] d2=new int[3];
            int r;
            int[] s=new int[2];
            String n="Player1";

            while(true)
            {
                Console.WriteLine("Halo, Pemain 1\n");
                Console.Write("Masukkan Namamu: "); n=Console.ReadLine();
                break;
            }

            Console.Clear();
            Console.Write("Selamat datang, "+n+"!\n\n");
            Console.Write("Loading...   ");
            int t = 5;

            Random rng = new Random();
            Random rng2 = new Random();

            for(r = 1; r<=10;r++)
            {
                Console.Clear();
                Console.WriteLine("Ronde "+r);
                Console.Write("Skor "+n+": "+s[0]+"\tSkor Komputer: "+s[1]);
                Console.WriteLine("\n-----");
                Console.WriteLine("Pada game ini, "+n+" dan Komputer akan mengocok 2 dadu.");
                Console.WriteLine("Jumlah mata dadu akan ditambahkan, yang jumlah nya paling tinggi menang");

                Console.Write("Mulai? [y/n] ");
                if(Console.ReadKey().KeyChar == 'n')
                {
                    break;
                }

                Console.WriteLine("\n\n-Giliran "+n+"-");
                Console.Write("Mengocok...    ");
                t = 0;
                while(t < 2)
                {
                    for(int i=0;i<13;i++)
                    {
                        Console.SetCursorPosition(Console.CursorLeft-3,Console.CursorTop);
                        d1[t] = rng.Next(1,7);
                        Console.Write("("+(d1[t])+")");
                        Thread.Sleep(60);
                    }
                    t++;
                    Thread.Sleep(1000);
                }
                Console.WriteLine("    ");
                Console.WriteLine("\nDadu 1: "+d1[0]);
                Console.WriteLine("Dadu 2: "+d1[1]);
                Console.WriteLine("Jumlah: "+(d1[2]=d1[1]+d1[0]));
                Console.WriteLine(" ");

                Thread.Sleep(1000);

                Console.WriteLine("-Giliran Komputer-");
                Console.Write("Mengocok...    ");
                t = 0;
                while(t < 2)
                {
                    for(int i=0;i<13;i++)
                    {
                        Console.SetCursorPosition(Console.CursorLeft-3,Console.CursorTop);
                        d2[t] = rng2.Next(1,7);
                        Console.Write("("+(d2[t])+")");
                        Thread.Sleep(60);
                    }
                    t++;
                    Thread.Sleep(1000);
                }
                Console.WriteLine("    ");
                Console.WriteLine("\nDadu 1: "+d2[0]);
                Console.WriteLine("Dadu 2: "+d2[1]);
                Console.WriteLine("Jumlah: "+(d2[2]=d2[1]+d2[0]));
                Console.WriteLine(" ");

                Thread.Sleep(1000);

                Console.WriteLine("-Hasil-");
                if(d1[2] > d2[2])
                {
                    Console.WriteLine(n +" -> ("+d1[2]+" > "+d2[2]+") <- Komputer");
                    Console.WriteLine(n+" Menang!");
                    s[0]++;
                }
                else if(d1[2] < d2[2])
                {
                    Console.WriteLine(n +" -> ("+d1[2]+" < "+d2[2]+") <- Komputer");
                    Console.WriteLine("Komputer Menang!");
                    s[1]++;
                }
                else
                {
                    Console.WriteLine(n +" -> ("+d1[2]+" = "+d2[2]+") <- Komputer");
                    Console.WriteLine("Imbang!");
                }

                Console.Write("\nLanjut? [y/n] ");
                if(Console.ReadKey().KeyChar == 'n')
                {
                    break;
                }

            }
            Console.Clear();
            if(r>=10)
            {
                Console.Write("Skor "+n+": "+s[0]+"\tSkor Komputer: "+s[1]);
                Console.WriteLine("\n-----");
                Console.WriteLine(" ");
                if(s[0]<s[1])
                {
                    Console.WriteLine("Komputer MENANG!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Komputer memenangkan game.\nSemoga beruntung lain kali, "+n+"!");
                }
                else if(s[0]>s[1])
                {
                    Console.WriteLine(n.ToUpper()+" MENANG!");
                    Console.WriteLine(" ");
                    Console.WriteLine(n+" memenangkan game.\nAyo main lagi!");
                }
                else
                {
                    Console.WriteLine("IMBANG!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Komputer dan "+n+" imbang.\nCoba lagi!");
                }
            }
            else
            {
                Console.WriteLine("---------");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("---------");
                Console.WriteLine("Player mengakhiri game di ronde "+r);
                Console.WriteLine("\nSkor sementara:");
                Console.WriteLine("- "+n+": "+s[0]);
                Console.WriteLine("- Komputer: "+s[1]);
                Console.WriteLine("\nAyo main lagi!");
            }
        }
    }
}