using System;

namespace RPGWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random attackRandom = new Random();
            int heroHealth = 10;
            int monsterHealth = 10;
            int round = 1;

            Console.WriteLine("The Hero have a first attack");
            Console.WriteLine("-----------------------------------");

            while(heroHealth > 0 && monsterHealth > 0)
            {
                Console.WriteLine($"ROUND {round}!");
                Console.WriteLine($"Hero's health: {heroHealth}/10\t\tMonster's health: {monsterHealth}/10");

                int heroAttack = attackRandom.Next(1, 10);
                monsterHealth -= heroAttack;
                Console.WriteLine($"ZIIN! The hero attacked with a sword !\nDamage:{heroAttack}");
                Console.WriteLine($"Hero's health: {heroHealth}/10\t\tMonster's health: {monsterHealth}/10");
                Console.WriteLine("");

                if(monsterHealth <= 0) {
                    Console.WriteLine("The Hero defeat the monster ! WINNER");
                    break;
                }
                Console.WriteLine("Now it's Monster turn");

                int monsterAttack = attackRandom.Next(1, 10);
                heroHealth -= monsterAttack;
                Console.WriteLine($"BOOOM! The monster attacked with a big punch !\nDamage:{monsterAttack}");
                Console.WriteLine($"Hero's health: {heroHealth}/10\t\tMonster's health: {monsterHealth}/10");
                Console.WriteLine("");

                if(heroHealth <= 0) {
                    Console.WriteLine("The Monster defeat the hero ! WINNER");
                    break;
                }

                Console.WriteLine("Next ROUND!");
                round++;
            }

        }
    }
}