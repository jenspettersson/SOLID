using System.Collections.Generic;

namespace Solid.Printer
{
    public interface ICopy
    {
        void PhotoCopy(List<Item> items);
    }
}