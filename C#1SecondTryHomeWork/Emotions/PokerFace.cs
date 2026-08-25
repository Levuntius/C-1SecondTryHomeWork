using C_1SecondTryHomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1SecondTryHomeWork.Emotions
{
    public class PokerFace : IEmotion
    {
        public void ExpressEmotion(string name)
        {
            Console.WriteLine($"{name} сохраняет покерфейс.");
        }
    }

}
