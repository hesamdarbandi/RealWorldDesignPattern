using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {

            var store = new Store();
            store.AttacheCustomer(new AppleLovers());
            store.AttacheCustomer(new GoogleLovers());
            store.RecieveNewAppleProducts();
            store.RecieveNewGoogleProducts();

            
        }
    }
}
