using System;
using System.Collections.Generic;
using System.Linq;

namespace Solid.Printer
{
    public interface IPrinter
    {
        void Print(IEnumerable<Item> items);
    }

    public interface IScan
    {
        void Scan(IEnumerable<Item> items);
    }

    public interface IStaple
    {
        void Staple(IEnumerable<Item> items);
    }

    public interface IFax
    {
        void Fax(IEnumerable<Item> items);
    }

    public interface ICopy
    {
        void Copy(IEnumerable<Item> items);
    }


    public class Printer : IPrinter
    {
        public void Print(IEnumerable<Item> items)
        {
            Console.WriteLine("Items printed: {0}", items.Count());
        }
    }

    public class Scanner : IScan
    {
        public void Scan(IEnumerable<Item> items)
        {
            Console.WriteLine("Items scanned: {0}", items.Count());
        }
    }

    public class Stapler : IStaple
    {
        public void Staple(IEnumerable<Item> items)
        {
            Console.WriteLine("Items stapled: {0}", items.Count());
        }
    }

    public class FaxMachine : IFax
    {
        public void Fax(IEnumerable<Item> items)
        {
            Console.WriteLine("Items faxed: {0}", items.Count());
        }
    }

    public class Copier : ICopy
    {
        public void Copy(IEnumerable<Item> items)
        {
            Console.WriteLine("Items copied: {0}", items.Count());
        }
    }
}
