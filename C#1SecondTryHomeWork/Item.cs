using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1SecondTryHomeWork
{
    class Item
    {
        public int Id;
        public string Name;

        public override int GetHashCode()
        {
            return 1;
        }

        public override bool Equals(object obj)
        {
            return obj is Item other &&
                   Id == other.Id &&
                   Name == other.Name;
        }
    }
}
