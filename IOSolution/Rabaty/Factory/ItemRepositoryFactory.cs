using Rabaty.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabaty.Factory
{
    public class ItemRepositoryFactory
    {
        public static IItemRepository GetItemRepository()
        {
            return new ItemRepository();
        }
    }
}
