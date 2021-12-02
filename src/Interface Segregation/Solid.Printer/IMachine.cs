using System.Collections.Generic;
using System.ComponentModel;

namespace Solid.Printer
{
    public class Temp2
    {
        public Temp2()
        {
            var superMegaHeavyMachine = new SuperMegaHeavyMachine();
            
            PrintStuff(superMegaHeavyMachine);
        }

        public void PrintStuff(IMachine machine)
        {
            machine.Print(new List<Item>());
        }

        public void FaxStuff(IMachine machine)
        {
            machine.Fax(new List<Item>());
        }
    }
    
    public interface IMachine : IPrint, IFax, IScan, IStaple, ICopy
    {

    }

    public class SuperMegaHeavyMachine : IMachine
    {
        public void Print(List<Item> items)
        {
            
        }

        public void Staple(List<Item> items)
        {
  
        }

        public void Fax(List<Item> items)
        {

        }

        public void Scan(List<Item> items)
        {

        }

        public void PhotoCopy(List<Item> items)
        {
 
        }
    }

    public class BudgetPrinter : IPrint
    {
        public void Print(List<Item> items)
        {
            
        }
    }
    
    public class SlimLineVersion : IPrint, ICopy, IScan
    {
        public void Print(List<Item> items)
        {
            
        }

        public void PhotoCopy(List<Item> items)
        {
            
        }

        public void Scan(List<Item> items)
        {
            
        }
    }
}