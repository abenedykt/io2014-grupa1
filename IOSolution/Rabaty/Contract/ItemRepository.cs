using Rabaty.Contract;
using Rabaty.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Factory
{
    class ItemRepository : IItemRepository
    {
        private IEnumerable<Item> _items;

        public ItemRepository()
        {
            this._items = new List<Item>()
            {
                new Item("00001", "Piłka do siatkówki", 19.99f, 0.23),
                new Item("00003", "Narty", 299.99f, 0.23),
                new Item("00004", "Rower", 1599.00f, 0.23),
                new Item("00002", "Bidon", 5.00f, 0.23),
                new Item("00005", "Piłka do koszykówki", 29.99f, 0.23),
                new Item("00006", "Strój bramkarski", 49.99f, 0.23),
            };
        }

        public Item GetItemById(string id)
        {
            return this._items.SingleOrDefault(x => x.Id == id);
        }
    }
}
