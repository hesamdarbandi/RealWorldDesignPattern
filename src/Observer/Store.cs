using System;
using System.Collections.Generic;

namespace Observer
{
    //this is subject or publisher class
    public class Store : IStore
    {
        // 1 new apple product arrive
        // 2 new google product arrive

        public int State = 0;
        private readonly List<IObserver> _customers;
        private const string STORE_LABLE = "store";

        public Store() =>  _customers = new List<IObserver>();

        public void AttacheCustomer(IObserver observer)
        {
            Console.WriteLine($"{STORE_LABLE} attache customer");
            if (_customers.Contains(observer))
                throw new Exception("customer already attached");

            _customers.Add(observer);
        }

        public void DetachCustomer(IObserver observer)
        {
            Console.WriteLine($"{STORE_LABLE} detach customer");
            _customers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine($"{STORE_LABLE} notify cutomers");
            _customers.ForEach(en =>
               en.Update(this)
            );
        }


        public void RecieveNewAppleProducts()
        {
            this.State = 1;
            Notify();
        }

        public void RecieveNewGoogleProducts()
        {
            this.State = 2;
            Notify();

        }


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
