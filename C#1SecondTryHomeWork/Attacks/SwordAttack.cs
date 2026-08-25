using C_1SecondTryHomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1SecondTryHomeWork.Attacks
{
    public class SwordAttack : IAttack
    {
        public void Attack(string name)
        {
            Console.WriteLine($"{name} наносит удар мечом!");
        }
    }

}
