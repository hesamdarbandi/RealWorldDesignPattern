using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Adapted chemical compounds
            ICompound water = new RichCompound("Water");
            water.Display();

            ICompound benzene = new RichCompound("Benzene");
            benzene.Display();

            ICompound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
        }
    }
}
