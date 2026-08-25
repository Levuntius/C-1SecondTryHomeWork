using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1SecondTryHomeWork
{
    public class Creature
    {
        public string Name {get; set;}
        public string Emotion {get; set;}
        public string Movement {get; set;}

        public Creature(string name)
        {
            Name = name;
            Emotion = "покерфейс";
            Movement = "стою";
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name} делает обычный удар.");
        }

        public void ShowState()
        {
            Console.WriteLine($"{Name}: эмоция = {Emotion}, движение = {Movement}");
        }
    }


}
