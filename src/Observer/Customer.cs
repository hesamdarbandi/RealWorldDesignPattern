using System;
namespace Observer
{
    public abstract class Customer
    {
        
    }

    public class AppleLovers : Customer , IObserver
    {

    }

    public class GoogleLovers : Customer , IObserver
    {

    }


    public interface IObserver
    {
        void Update(Store store);
    }

    public interface 
}
