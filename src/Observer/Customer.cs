using System;
namespace Observer
{
    public abstract class Customer
    {
        
    }

    public class AppleLovers : Customer , IObserver
    {
        public void Update(Store store)
        {
            if (store.State == 1)
                Console.WriteLine("hey apple lovers : new apple products receive");
        }
    }

    public class GoogleLovers : Customer , IObserver
    {
        public void Update(Store store)
        {
            if (store.State == 2)
                Console.WriteLine("hey google lovers : new google products receive");
        }
        
    }


    public interface IObserver
    {
        void Update(Store store);
    }

 
}
