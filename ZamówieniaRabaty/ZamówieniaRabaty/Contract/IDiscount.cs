using System.Collections.Generic;

namespace ZamówieniaRabaty.Contract
{
    public interface IDiscount
    {
        string Name { get; set; }

        void Calculate(IEnumerable<IItem> items);
    }
}
