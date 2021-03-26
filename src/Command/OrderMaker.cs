using System;
namespace Command
{
    //this is reciever class
    public class OrderMaker
    {
        public void CreatePitza(string type, string size) => Console.WriteLine($"created {type} pitza with {size} size");

        public void CreateSandwich(string type, string size) => Console.WriteLine($"created {type} pitza with {size} size");

    }
}
