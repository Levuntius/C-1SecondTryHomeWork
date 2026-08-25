using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1SecondTryHomeWork
{
    public class Screamer : Creature
    {
        public Screamer(string name) : base(name) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} орёт так громко, что враг оглушён!");
        }
    }

}
