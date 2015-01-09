using Rabaty.Model;
using System;
namespace Rabaty.Contract
{
    public interface IItemRepository
    {
        Item GetItemById(string id);
    }
}
