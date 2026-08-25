using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1SecondTryHomeWork
{
    public class Archer : Creature
    {
        public Archer(string name) : base(name) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} стреляет из лука!");
        }
    }

}
