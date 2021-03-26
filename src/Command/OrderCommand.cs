using System;
namespace Command
{
    // this is commands
    public interface ICommand
    {
        public void Execute();
    };

    public class CreatePizzaCommand:  ICommand
    {
        private string _type;
        private string _size;
        private OrderMaker _orderMaker;

        public CreatePizzaCommand(string type,string size)
        {
            _orderMaker = new OrderMaker();
            _type = type;
            _size = size;
        }

        public void Execute() => _orderMaker.CreatePitza(_type, _size);

    }

    public class CreateSandwichCommand : ICommand
    {
        private string _type;
        private string _size;
        private OrderMaker _orderMaker;

        public CreateSandwichCommand(string type, string size)
        {
            _orderMaker = new OrderMaker();
            _type = type;
            _size = size;
        }

        public void Execute() => _orderMaker.CreateSandwich(_type, _size);

    }

}
