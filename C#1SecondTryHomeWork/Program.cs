namespace C_1SecondTryHomeWork
{
    using C_1SecondTryHomeWork.Enemy_types;
    using System;
    using System.Collections.Generic;

namespace LevLesson
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int monsterAmount = 10;
                int fightsAmount = 2;

                for (int rep = 0; rep < fightsAmount; rep++)
                {
                    Console.WriteLine($"\n=== Бой #{rep + 1} начинается ===\n");

                    List<Enemy> monsters = new List<Enemy>();

                    // monsterSpawn
                    for (int i = 0; i < monsterAmount; i++)
                        monsters.Add(MonsterSpawner.CreateRandomMonster(i));

                    Random rnd = new Random();

                    // fight
                    while (monsters.Count > 1)
                    {
                        for (int i = 0; i < monsters.Count; i++)
                        {
                            Enemy attacker = monsters[i];

                            int randomIndex = rnd.Next(monsters.Count - 1);
                            if (randomIndex >= i)
                                randomIndex++;

                            Enemy target = monsters[randomIndex];

                            attacker.Attack(target);

                            // удаление мёртвых
                            monsters.RemoveAll(m => m.IsDead);

                            if (monsters.Count <= 1)
                                break;
                        }
                    }

                    Console.WriteLine($"\n=== Победитель: {monsters[0].Name} ===\n");
                }
            }
        }
    }

}
