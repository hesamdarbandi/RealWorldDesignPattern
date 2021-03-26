using System;
namespace Command
{
    // this is invoker class
    public class Waiter
    {
        private ICommand _command;

        public void SetCommand(ICommand command) => _command = command;

        public void TaKeOrder() => _command.Execute();
    }
}
