using System;
using System.Collections.Generic;

namespace Observer
{
    //this is subject or publisher class
    public class Store
    {
        private readonly List<IObserver> _customers;

        public Store() =>  _customers = new List<IObserver>();

       
    }

    public interface IStore
    {
        void AttacheCustomer(IObserver observer);
        void DetachCustomer(IObserver observer);
        void Notify();
        void RecieveNewAppleProducts();
        void RecieveNewGoogleProducts();
    }

}
