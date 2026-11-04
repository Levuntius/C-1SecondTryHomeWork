using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1SecondTryHomeWork
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public bool IsFlying { get; set; }

        public Enemy(string name, int hp, bool isFlying)
        {
            Name = name;
            Hp = hp;
            IsFlying = isFlying;
        }

        public void TakeDamage(int damage)
        {
            Hp -= damage;
            if (Hp < 0) Hp = 0;
            Console.WriteLine($"   [{Name}] получил {damage} урона. Осталось HP: {Hp}");
        }
    }
}
