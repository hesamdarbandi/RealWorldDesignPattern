using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {

            var waiter = new Waiter();
            var newPitzaCommand = new CreatePizzaCommand("peperoni","small");
            waiter.SetCommand(newPitzaCommand);
            waiter.TaKeOrder();

            var newSanCommand = new CreateSandwichCommand("hotdog", "big");
            waiter.SetCommand(newSanCommand);
            waiter.TaKeOrder();
        }
    }
}
