using System;
using System.Collections.Generic;

namespace Bad.Printer
{
    public interface IMachine
    {
        void Print(List<Item> items);
        void Staple(List<Item> items);
        void Fax(List<Item> items);
        void Scan(List<Item> items);
        void PhotoCopy(List<Item> items);
    }

    public class SuperMegaPrinterMachine : IMachine
    {
        public void Print(List<Item> items)
        {
            Console.WriteLine("Items printed: {0}", items.Count);
        }

        public void Staple(List<Item> items)
        {
            Console.WriteLine("Items stapled: {0}", items.Count);
        }

        public void Fax(List<Item> items)
        {
            Console.WriteLine("Items faxed: {0}", items.Count);
        }

        public void Scan(List<Item> items)
        {
            Console.WriteLine("Items scanned: {0}", items.Count);
        }

        public void PhotoCopy(List<Item> items)
        {
            Console.WriteLine("Items copied: {0}", items.Count);
        }
    }
    
    public class SlimLineSuperMachine : IMachine
    {
        public void Print(List<Item> items)
        {
            Console.WriteLine("Items printed: {0}", items.Count);
        }

        public void Staple(List<Item> items)
        {
            throw new NotImplementedException();
        }

        public void Fax(List<Item> items)
        {
            throw new Exception("Boom!");
        }

        public void Scan(List<Item> items)
        {
            Console.WriteLine("Items scanned: {0}", items.Count);
        }

        public void PhotoCopy(List<Item> items)
        {
            Console.WriteLine("Items copied: {0}", items.Count);
        }
    }

    public class Temp
    {
        public Temp()
        {
            var machine = new SlimLineSuperMachine();
            
            machine.Fax(new List<Item>{new Item()});
        }
    }
}
