using System;
namespace Mediator
{
    public class Client : Participant
    {
        public Client(string name) : base(name) { }

        public override void Receive(string from, string message)=> base.Receive(from, message);
        
    }
}
