using System;
//Dosen Pengampu : Rahmat Rizal Andhi, S.T., M.T.

//Dibuat oleh :
//Fahrozy Hidayat
//2207112592
//Teknik Informatika A
namespace DasproAdventure{
    class Program{
            static void Main(string[] args)
            {
                Console.WriteLine("Selamat Datang di RPG Sekai");
                Console.WriteLine("Siapa namamu, wahai petualang ?");
                Novice player = new Novice();
                player.Name = Console.ReadLine();
                Console.WriteLine("Halo "+player.Name+", apakah kamu siap memulai petualangan ? [y/n]");
                string bReady = Console.ReadLine();
                if(bReady=="y"){
                    Console.WriteLine(player.Name+" memasuki RPG Sekai...");
                    Enemy enemy1 = new Enemy("Slime");
                    Console.WriteLine(player.Name+" sedang menghadapi "+enemy1.Name);
                    Console.WriteLine(enemy1.Name+" menyerang "+player.Name);
                    Console.WriteLine("Pilih tindakan : ");
                    Console.WriteLine("[1] Serangan Biasa (o_o)-(===>");
                    Console.WriteLine("[2] Serangan Kuat (>o<)-(===>");
                    Console.WriteLine("[3] Berlindung (o_o)-U");
                    Console.WriteLine("[4] NIGERUNDAYO!! ┌(>o<)┘");

                    while (!player.isDead && !enemy1.isDead){
                        string playerAction = Console.ReadLine();
                        switch(playerAction)
                        {
                            case "1" :
                            Console.WriteLine(player.Name+ " memilih Serangan Biasa!");
                            enemy1.GetHit(player.AttackPower);
                            player.Experience += 0.3f;
                            enemy1.Attack(enemy1.AttackPower);
                            player.GetHit(enemy1.AttackPower);
                            Console.Write("HP" +player.Name+ ":" +player.Health+ " | HP musuh : " +enemy1.Health+"\n");
                            break;
                            case "2" :
                            player.Swing();
                            player.Experience += 0.3f;
                            enemy1.GetHit(player.AttackPower);
                            Console.Write("HP " +player.Name+ ":" +player.Health+ " | HP musuh : " +enemy1.Health+"\n");
                            break;
                            case "3" :
                            player.Rest();
                            Console.WriteLine("sedang memulihkan Stamina");
                            enemy1.Attack(enemy1.AttackPower);
                            player.GetHit(enemy1.AttackPower);
                            break;
                            case "4" :
                            Console.WriteLine(player.Name+ " kabur dari zona pertarungan...");
                            break;
                        }
                    }
                    Console.WriteLine(player.Name+ " mendapat " +player.Experience+ " EXP.");
                }

                else{
                    Console.WriteLine("Semoga berjumpa lagi, petualang...");
                    Console.Read();
                }
            }
    }
    class Novice{
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool isDead { get; set; }
        public float Experience { get; set; }
        Random rnd = new Random();

        public Novice(){
            Health = 100;
            SkillSlot = 0;
            AttackPower = 1;
            isDead = false;
            Experience = 0;
            Name = "Newbie";
        }

        public void Swing(){
            if(SkillSlot > 0){
                Console.WriteLine("SLASH!!");
                AttackPower = AttackPower + rnd.Next(3,11);
                SkillSlot--;
            }
            else{
                Console.WriteLine("kamu tidak memiliki Stamina!");
            }
        }
        public void GetHit(int hitValue){
            Console.WriteLine(Name+ " terkena serangan sebesar " +hitValue);
            Health = Health - hitValue;

            if(Health <- 0){
                Health = 0;
                Die();
            }
        }

        public void Rest(){
            SkillSlot = 3;
            AttackPower = 1;
        }

        public void Die(){
            Console.WriteLine("Kamu mati (✖∇✖)...GAME OVER");
            isDead = true;
        }
    }
    class Enemy{
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool isDead { get; set; }
        public float Experience { get; set; }
        Random rnd = new Random();

        public Enemy(string name){
            Health = 50;
            Name = name;
        }
        public void Attack(int damage){
            AttackPower = rnd.Next(1,10);
        }
        public void GetHit(int hitValue){
            Console.WriteLine(Name+ " terkena serangan sebesar " +hitValue);
            Health = Health - hitValue;

            if(Health <- 0){
                Health = 0;
                Die();
            }
        }
        public void Die(){
            Console.WriteLine(Name+ "telah dikalahkan");
            isDead = true;
        }
    }
}