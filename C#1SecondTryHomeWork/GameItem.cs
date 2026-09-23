using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1SecondTryHomeWork
{
    public class GameItem
    {
        private int _id;
        private string _name;
        private int _maxStack;

        public int Id => _id;
        public string Name => _name;
        public int MaxStack => _maxStack;

        public GameItem(int id, string name, int maxStack)
        {
            _id = id;
            _name = name;
            _maxStack = maxStack;
        }

        public override bool Equals(object obj)
        {
            return obj is GameItem other && _id == other._id;
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{_name} (ID={_id})";
        }
    }

}
