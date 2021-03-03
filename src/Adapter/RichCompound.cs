using System;
namespace Adapter
{
    class RichCompound : ICompound
    {
        private ChemicalDatabank _bank;
        private string _name;

        public RichCompound(string name) => _name = name;
        

        public void Display()
        {
            // The Adaptee
            _bank = new ChemicalDatabank();

            Console.WriteLine(" Formula: {0}", _bank.GetMolecularStructure(_name));
            Console.WriteLine(" Weight : {0}", _bank.GetMolecularWeight(_name));
            Console.WriteLine(" Melting Pt: {0}", _bank.GetCriticalPoint(_name, "M"));
            Console.WriteLine(" Boiling Pt: {0}", _bank.GetCriticalPoint(_name, "B"));
        }
    }
}
