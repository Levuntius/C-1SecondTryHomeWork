using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1SecondTryHomeWork
{
    using System;
    using System.Collections.Generic;

    public class Inventory
    {
        private Dictionary<GameItem, int> _items = new Dictionary<GameItem, int>();

        public void AddItem(GameItem item, int amount)
        {
            if (_items.ContainsKey(item))
            {
                int newAmount = _items[item] + amount;

                if (newAmount > item.MaxStack)
                {
                    _items[item] = item.MaxStack;
                    Console.WriteLine("Инвентарь переполнен часть предметов выброшена");
                }
                else
                {
                    _items[item] = newAmount;
                }
            }
            else
            {
                int finalAmount = Math.Min(amount, item.MaxStack);
                _items.Add(item, finalAmount);

                if (amount > item.MaxStack)
                    Console.WriteLine("Инвентарь переполнен часть предметов выброшена");
            }
        }

        public void RemoveItem(GameItem item, int amount)
        {
            if (!_items.ContainsKey(item))
                return;

            int newAmount = _items[item] - amount;

            if (newAmount <= 0)
            {
                _items.Remove(item);
            }
            else
            {
                _items[item] = newAmount;
            }
        }

        // Индексатор для перебора через for
        public KeyValuePair<GameItem, int> this[int index]
        {
            get
            {
                if (index < 0 || index >= _items.Count)
                    throw new IndexOutOfRangeException();

                int i = 0;
                foreach (var pair in _items)
                {
                    if (i == index)
                        return pair;
                    i++;
                }

                throw new IndexOutOfRangeException();
            }
        }

        public int Count => _items.Count;
    }


}
