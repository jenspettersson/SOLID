using System.Collections.Generic;

namespace Solid.Printer
{
    public interface IPrint
    {
        void Print(List<Item> items);
    }
}