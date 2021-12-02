using System.Collections.Generic;

namespace Solid.Printer
{
    public interface IFax
    {
        void Fax(List<Item> items);
    }
}