using C_1SecondTryHomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1SecondTryHomeWork.Movement
{
    public class Run : IMovement
    {
        public void Move(string name)
        {
            Console.WriteLine($"{name} бежит.");
        }
    }

}
