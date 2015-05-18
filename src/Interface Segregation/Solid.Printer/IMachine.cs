using System.Collections.Generic;

namespace Solid.Printer
{
    public interface IMachine : IPrinter, IScan, IStaple, IFax, ICopy { }

    public class SuperMegaPrinterMachine : IMachine
    {
        private readonly IPrinter _printer;
        private readonly IScan _scanner;
        private readonly IStaple _stapler;
        private readonly IFax _fax;
        private readonly ICopy _copier;

        public SuperMegaPrinterMachine(
            IPrinter printer,
            IScan scanner,
            IStaple stapler,
            IFax fax,
            ICopy copier)
        {
            _printer = printer;
            _scanner = scanner;
            _stapler = stapler;
            _fax = fax;
            _copier = copier;
        }

        public void Print(IEnumerable<Item> items)
        {
            _printer.Print(items);
        }

        public void Scan(IEnumerable<Item> items)
        {
            _scanner.Scan(items);
        }

        public void Staple(IEnumerable<Item> items)
        {
            _stapler.Staple(items);
        }

        public void Fax(IEnumerable<Item> items)
        {
            _fax.Fax(items);
        }

        public void Copy(IEnumerable<Item> items)
        {
            _copier.Copy(items);
        }
    }
}