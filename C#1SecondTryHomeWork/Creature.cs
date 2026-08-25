using C_1SecondTryHomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1SecondTryHomeWork
{
    public class Creature
    {
        public string Name {get;}
        public IAttack AttackType {get;}
        public IMovement MovementType {get;}
        public IEmotion EmotionType {get;}

        public Creature(string name, IAttack attack, IMovement movement, IEmotion emotion)
        {
            Name = name;
            AttackType = attack;
            MovementType = movement;
            EmotionType = emotion;
        }

        public void ShowState()
        {
            EmotionType.ExpressEmotion(Name);
            MovementType.Move(Name);
            AttackType.Attack(Name);
        }
    }

}
