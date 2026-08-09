namespace C_1SecondTryHomeWork
{
    public static class MonsterSpawner
    {
        private static Random rnd = new Random();

        public static Enemy CreateRandomMonster(int id)
        {
            int type = rnd.Next(6);

            return type switch
            {
                0 => new Orc($"Орк{id}", 100),
                1 => new Dragon($"Дракон{id}", 120),
                2 => new Skeleton($"Скелет{id}", 60),
                3 => new Werewolf($"Оборотень{id}", 90),
                4 => new Zombie($"Зомби{id}", 110),
                5 => new Vampire($"Вампир{id}", 80),
                _ => new Orc($"Орк{id}", 100)
            };
        }
    }
}

